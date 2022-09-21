using System.Security.Cryptography;
using System.Text;
using CatSdk.Utils;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace CatSdk.Crypto
{
    public class Crypto
    {
        /**
         * Generate random bytes by length
         * @param {byte} length - The length of the random bytes
         *
         * @return {byte[]}
         */
        public static byte[] RandomBytes(byte length)
        {
            var rngCsp = RandomNumberGenerator.Create();
            var randomBytes = new byte[length];
            rngCsp.GetBytes(randomBytes);
            return randomBytes;
        }

        public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
        {
            var plainBytes = Converter.HexToBytes(plainText);
            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters =
                new AeadParameters(new KeyParameter(key), 128, iv);

            cipher.Init(true, parameters);

            var encryptedBytes = new byte[cipher.GetOutputSize(plainBytes.Length)];
            var retLen = cipher.ProcessBytes
                (plainBytes, 0, plainBytes.Length, encryptedBytes, 0);
            cipher.DoFinal(encryptedBytes, retLen);
            using var combinedStream = new MemoryStream();
            using (var binaryWriter = new BinaryWriter(combinedStream))
            {
                binaryWriter.Write(iv);
                binaryWriter.Write(encryptedBytes);
            }
                
            var combinedStreamArray = combinedStream.ToArray();
            var result = new byte[combinedStreamArray.Length];
            Array.Copy(combinedStreamArray, combinedStreamArray.Length - 16, result, 0,  16);
            Array.Copy(combinedStreamArray, 0, result, 16,  combinedStreamArray.Length - 16);
            return result;
        }
        
        public static byte[]? Decrypt(byte[] encryptedMessage, byte[] key)
        {
            var newArray = new byte[encryptedMessage.Length];
            Array.Copy(encryptedMessage, 16, newArray, 0,  12);
            Array.Copy(encryptedMessage, 28, newArray, 12,  encryptedMessage.Length - 28);
            Array.Copy(encryptedMessage, 0, newArray, encryptedMessage.Length - 16,  16);
            using var cipherStream = new MemoryStream(newArray);
            using var cipherReader = new BinaryReader(cipherStream);

            var iv = cipherReader.ReadBytes(12);
            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(new KeyParameter(key), 128, iv);
            cipher.Init(false, parameters);
            var cipherText = cipherReader.ReadBytes(encryptedMessage.Length - iv.Length);
            var plainText = new byte[cipher.GetOutputSize(cipherText.Length)];  

            try
            {
                var len = cipher.ProcessBytes(cipherText, 0, cipherText.Length, plainText, 0);
                cipher.DoFinal(plainText, len);
            }
            catch (InvalidCipherTextException)
            {
                return null;
            }

            return plainText;
        }

        /***
         * Encode a message, separated from encode() to help testing
         *
         * @param {string} senderPriv - A sender private key
         * @param {string} recipientPub - A recipient public key
         * @param {string} msg - A text message
         * @param {Uint8Array} iv - An initialization vector
         * @param {Uint8Array} salt - A salt
         * @return {string} - The encoded message
         */
        private static string _Encode(byte[] senderPrivateKey, byte[] recipientPub, string msg, byte[] iv)
        {
            var encKey = CatapultCrypto.DeriveSharedKey(senderPrivateKey, recipientPub);
            var cipher = Encrypt(msg, encKey, iv);
            return Converter.BytesToHex(cipher);
        }

        /**
         * Encode a message using AES-GCM algorithm
         *
         * @param {string} senderPriv - A sender private key
         * @param {string} recipientPub - A recipient public key
         * @param {string} msg - A text message
         * @param {boolean} isHexString - Is payload string a hexadecimal string (default = false)
         * @return {string} - The encoded message
         */
        public static string Encode(string senderPrivateKey, string recipientPub, string msg, bool isHexString = false)
        {
            var iv = RandomBytes(12);
            return _Encode(Converter.HexToBytes(senderPrivateKey), Converter.HexToBytes(recipientPub), isHexString ? msg : Converter.Utf8ToHex(msg), iv);
        }
        
        public static string Encode(byte[] senderPrivateKey, string recipientPub, string msg, bool isHexString = false)
        {
            var iv = RandomBytes(12);
            return _Encode(senderPrivateKey, Converter.HexToBytes(recipientPub), isHexString ? msg : Converter.Utf8ToHex(msg), iv);
        }
        
        public static string Encode(string senderPrivateKey, byte[] recipientPub, string msg, bool isHexString = false)
        {
            var iv = RandomBytes(12);
            return _Encode(Converter.HexToBytes(senderPrivateKey), recipientPub, isHexString ? msg : Converter.Utf8ToHex(msg), iv);
        }
        
        public static string Encode(byte[] senderPrivateKey, byte[] recipientPub, string msg, bool isHexString = false)
        {
            var iv = RandomBytes(12);
            return _Encode(senderPrivateKey, recipientPub, isHexString ? msg : Converter.Utf8ToHex(msg), iv);
        }
        
        /**
         * Decode an encrypted message payload
         *
         * @param {string} recipientPrivate - A recipient private key
         * @param {string} senderPublic - A sender public key
         * @param {Uint8Array} payload - An encrypted message payload in bytes
         * @param {Uint8Array} tagAndIv - 16-bytes AES auth tag and 12-byte AES initialization vector
         * @return {string} - The decoded payload as hex
         */
        public static string? _Decode(byte[] recipientPrivateKey, byte[] senderPublic, byte[] payload) {
            var encKey = CatapultCrypto.DeriveSharedKey(recipientPrivateKey, senderPublic);
            var cipher = Decrypt(payload, encKey);
            return cipher == null ? null : Converter.BytesToHex(cipher);
        }

        /**
         * Decode an encrypted (AES-GCM algorithm) message payload
         *
         * @param {string} recipientPrivate - A recipient private key
         * @param {string} senderPublic - A sender public key
         * @param {string} payload - An encrypted message payload
         * @return {string?} - The decoded payload as hex
         */
        public static string? Decode(string recipientPrivateKey, string senderPublic, string payload) {
            var decoded = _Decode(Converter.HexToBytes(recipientPrivateKey), Converter.HexToBytes(senderPublic), Converter.HexToBytes(payload));
            return decoded != null ? Converter.HexToUtf8(decoded) : null;
        }
        
        public static string? Decode(byte[] recipientPrivateKey, string senderPublic, string payload) {
            var decoded = _Decode(recipientPrivateKey, Converter.HexToBytes(senderPublic), Converter.HexToBytes(payload));
            return decoded != null ? Converter.HexToUtf8(decoded) : null;
        }
        
        public static string? Decode(string recipientPrivateKey, byte[] senderPublic, string payload) {
            var decoded = _Decode(Converter.HexToBytes(recipientPrivateKey), senderPublic, Converter.HexToBytes(payload));
            return decoded != null ? Converter.HexToUtf8(decoded) : null;
        }
        
        public static string? Decode(byte[] recipientPrivateKey, byte[] senderPublic, string payload) {
            var decoded = _Decode(recipientPrivateKey, senderPublic, Converter.HexToBytes(payload));
            return decoded != null ? Converter.HexToUtf8(decoded) : null;
        }
        
        private static Aes CreateAesManaged(string key, string iv)
        {
            var aes = Aes.Create();
            aes.KeySize = 128;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.IV = Encoding.UTF8.GetBytes(iv);
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.Padding = PaddingMode.PKCS7;
            return aes;
        }
        
        public static string Encrypt(string text, string key, string iv)
        {
            var aes = CreateAesManaged(key, iv);
            var byteText = Encoding.UTF8.GetBytes(text);
            var encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);
            return Convert.ToBase64String(encryptText);
        }

        public static string Decrypt(string text, string key, string iv)
        {
            using var aes = CreateAesManaged(key, iv);
            var src = Convert.FromBase64String(text);
            var dest = aes.CreateDecryptor().TransformFinalBlock(src, 0, src.Length);
            return Encoding.UTF8.GetString(dest);
        }
        
        public static string EncryptString(string sourceString, string password, string salt)
        {
            using var rijndael = Aes.Create("AesManaged");
            if (rijndael == null) throw new Exception("rijndael is null");
            GenerateKeyFromPassword(password, rijndael.KeySize, out var key, rijndael.BlockSize, out var iv, salt);
            rijndael.Key = key;
            rijndael.IV = iv;

            var strBytes = Encoding.UTF8.GetBytes(sourceString);
            using var encryptor = rijndael.CreateEncryptor();
            var encBytes = encryptor.TransformFinalBlock(strBytes, 0, strBytes.Length);
            return Convert.ToBase64String(encBytes);
        }

        public static string DecryptString(string sourceString, string password, string salt)
        {
            using var rijndael = Aes.Create("AesManaged");
            if (rijndael == null) throw new Exception("rijndael is null");
            GenerateKeyFromPassword(password, rijndael.KeySize, out var key, rijndael.BlockSize, out var iv, salt);
            rijndael.Key = key;
            rijndael.IV = iv;

            var strBytes = Convert.FromBase64String(sourceString);
            using var decryptor = rijndael.CreateDecryptor();
            var decBytes = decryptor.TransformFinalBlock(strBytes, 0, strBytes.Length);
            return Encoding.UTF8.GetString(decBytes);
        }

        private static void GenerateKeyFromPassword(string password,
            int keySize, out byte[] key, int blockSize, out byte[] iv, string salt)
        {
            var saltBytes = Encoding.UTF8.GetBytes(salt);
            var deriveBytes = new Rfc2898DeriveBytes(password, saltBytes);
            deriveBytes.IterationCount = 1000;
            key = deriveBytes.GetBytes(keySize / 8);
            iv = deriveBytes.GetBytes(blockSize / 8);
        }
    }
}