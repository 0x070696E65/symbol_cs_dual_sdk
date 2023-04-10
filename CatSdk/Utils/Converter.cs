using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CatSdk.Utils
{
    public static class Converter
    {
        private static readonly Dictionary<string, Dictionary<string, byte>> _constants = new Dictionary<string, Dictionary<string, byte>>
        {
            {
                "sizes",
                new Dictionary<string, byte>{
                    {"ripemd160", 20},
                    {"symbolAddressDecoded", 24},
                    {"nemAddressDecoded", 40},
                    {"symbolAddressEncoded", 39},
                    {"nemAddressEncoded", 40},
                    {"key", 32},
                    {"checksum", 3},
                }
            }
        };

        /**
	     * Converts a hex string to a uint8 array.
	     * @param {string} input A hex encoded string.
	     * @returns {byte[]} A uint8 array corresponding to the input.
	     */
        public static byte[] HexToBytes(string hexString)
        {
            var bs = new List<byte>();
            for (var i = 0; i < hexString.Length / 2; i++)
            {
                bs.Add(Convert.ToByte(hexString.Substring(i * 2, 2), 16));
            }
            return bs.ToArray();
        }

        /**
	     * Converts a uint8 array to a hex string.
	     * @param {byte[]} input A uint8 array.
	     * @returns {string} A hex encoded string corresponding to the input.
	     */
        public static string BytesToHex(byte[] bytes)
        {
            var str = BitConverter.ToString(bytes.ToArray());
            str = str.Replace("-", string.Empty);
            return str;
        }

        /**
         * Converts an encoded address string to a decoded address.
         * @param {string} encoded The encoded address string.
         * @returns {byte[]} The decoded address corresponding to the input.
         */
        public static byte[] StringToAddress(string encoded)
        {
            if (_constants["sizes"]["symbolAddressEncoded"] == encoded.Length)
            {
                var bytes = Base32.Decode(encoded + "A");
                Array.Resize(ref bytes, _constants["sizes"]["symbolAddressDecoded"]);
                return bytes;
            }
            if (_constants["sizes"]["nemAddressEncoded"] == encoded.Length)
            {
                return Base32.Decode(encoded);
            }
            throw new Exception(encoded + " does not represent a valid encoded address");
        }

        /*
         * Converts a decoded address to an encoded address string.
         * @param {byte[]} decoded The decoded address.
         * @returns {string} The encoded address string corresponding to the input.
         */
        public static string AddressToString(byte[] decoded)
        {
            if (_constants["sizes"]["symbolAddressDecoded"] != decoded.Length)
            {
                var padded = new byte[_constants["sizes"]["addressDecoded"] + 1];
                Array.Copy(decoded, padded, decoded.Length);
                return Base32.Encode(padded).Substring(0, _constants["sizes"]["symbolAddressEncoded"]);
            }
            if (_constants["sizes"]["nemAddressDecoded"] != decoded.Length)
            {
                return Base32.Encode(decoded);
            }
            throw new Exception(BytesToHex(decoded) + " does not represent a valid decoded address");
        }

        /**
         * Convert UTF-8 to hex
         * @param {string} input - An UTF-8 string
         * @return {string}
         */
        public static string Utf8ToHex(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            var hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        public static byte[] Utf8ToBytes(string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static string HexToUtf8(string input)
        {
            return Encoding.UTF8.GetString(Converter.HexToBytes(input));
        }

        public static byte[] Utf8ToPlainMessage(string input)
        {
            var message = Encoding.UTF8.GetBytes(input);
            var zero = new byte[] { 0 };
            var newArr = new byte[message.Length + 1];
            zero.CopyTo(newArr, 0);
            message.CopyTo(newArr, 1);
            return newArr;
        }

        public static byte[] Utf8ToEncryptoMessage(string input)
        {
            var message = Encoding.UTF8.GetBytes(input);
            var zero = new byte[] { 1 };
            var newArr = new byte[message.Length + 1];
            zero.CopyTo(newArr, 0);
            message.CopyTo(newArr, 1);
            return newArr;
        }

        public static string ToHex<T>(T value, byte i = 0)
        {
            return i switch
            {
                0 => $"{value:X}",
                2 => $"{value:X2}",
                4 => $"{value:X4}",
                8 => $"{value:X8}",
                16 => $"{value:X16}",
                32 => $"{value:X32}",
                64 => $"{value:X64}",
                _ => throw new Exception("i is not excepted value")
            };
        }

        public static string ToString<T>(T value)
        {
            return "0x" + $"{value:X}";
        }

        private static string ToPascal(string text)
        {
            return Regex.Replace(
                text.Replace("_", " "),
                @"\b[a-z]",
                match => match.Value.ToUpper()).Replace(" ", "");
        }

        public static bool IsHexString(string s)
        {
            return !string.IsNullOrEmpty(s) && s.All(Uri.IsHexDigit);
        }

        public static byte[] Xor(byte[] currentMetadataValueBytes, byte[] newMetadataValueBytes)
        {
            var length = Math.Max(currentMetadataValueBytes.Length, newMetadataValueBytes.Length);
            for (var i = currentMetadataValueBytes.Length; i < length; i++) currentMetadataValueBytes.ToList().Add(0);
            for (var i = newMetadataValueBytes.Length; i < length; i++) newMetadataValueBytes.ToList().Add(0);
            var metadataNewlist = new List<byte>();
            for (var i = 0; i < length; i++) metadataNewlist.Add((byte)(currentMetadataValueBytes[i] ^ newMetadataValueBytes[i]));
            return metadataNewlist.ToArray();
        }
    }
}