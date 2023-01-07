using System;
using System.Security.Cryptography;

namespace CatSdk.Crypto
{
    public class Hkdf
    {
        readonly Func<byte[], byte[], byte[]> keyedHash;

        public Hkdf()
        {
            var hmac = new HMACSHA256();
            keyedHash = (key, message) =>
            {
                hmac.Key = key;
                return hmac.ComputeHash(message);
            };
        }

        private byte[] Extract(byte[] salt, byte[] inputKeyMaterial)
        {
            return keyedHash(salt, inputKeyMaterial);
        }

        private byte[] Expand(byte[] prk, byte[] info, int outputLength)
        {
            var resultBlock = Array.Empty<byte>();
            var result = new byte[outputLength];
            var bytesRemaining = outputLength;
            for (int i = 1; bytesRemaining > 0; i++)
            {
                var currentInfo = new byte[resultBlock.Length + info.Length + 1];
                Array.Copy(resultBlock, 0, currentInfo, 0, resultBlock.Length);
                Array.Copy(info, 0, currentInfo, resultBlock.Length, info.Length);
                currentInfo[currentInfo.Length - 1] = (byte)i;
                resultBlock = keyedHash(prk, currentInfo);
                Array.Copy(resultBlock, 0, result, outputLength - bytesRemaining, Math.Min(resultBlock.Length, bytesRemaining));
                bytesRemaining -= resultBlock.Length;
            }
            return result;
        }

        public byte[] DeriveKey(byte[] salt, byte[] inputKeyMaterial, byte[] info, int outputLength)
        {
            var prk = Extract(salt, inputKeyMaterial);
            var result = Expand(prk, info, outputLength);
            return result;
        }
    }
}