using System;
using System.Security.Cryptography;
using System.Text;

namespace CatSdk.Crypto
{
    public static class CatapultCrypto
    {
        const int Key_Size = 32;

        static void Clamp(byte[] d)
        {
            d[0] &= 248;
            d[31] &= 127;
            d[31] |= 64;
        }

        static byte[] PrepareForScalarMult(byte[] sk)
        {
            using var sha = SHA512.Create();
            var d = new byte[64];
            var hash = sha.ComputeHash(sk);
            Array.Copy(hash, d, 32);
            Clamp(d);
            return d;
        }

        public static byte[] DeriveSharedKey(byte[] privateKey, byte[] publicKey)
        {
            var sharedSecret = DeriveSharedSecret(privateKey, publicKey);
            const string info = "catapult";
            var hkdf = new Hkdf();
            return hkdf.DeriveKey(new byte[32], sharedSecret, Encoding.UTF8.GetBytes(info), 32);
        }

        private static byte[] DeriveSharedSecret(byte[] privateKey, byte[] publicKey)
        {
            var d = PrepareForScalarMult(privateKey);
            var q = new[] { NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf() };
            var p = new[] { NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf(), NaclCatapult.Gf() };
            var sharedSecret = new long[Key_Size];

            NaclCatapult.Unpack(q, publicKey);
            NaclCatapult.Scalarmult(p, q, d);
            NaclCatapult.Pack(sharedSecret, p);
            var result = new byte[32];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = (byte)sharedSecret[i];
            }
            return result;
        }
    }
}