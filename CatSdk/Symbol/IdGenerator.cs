using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Symbol
{
    public static class IdGenerator
    {
        private const ulong NAMESPACE_FLAG = (ulong)1 << 63;

        /**
         * Generates a mosaic id from an owner address and a nonce.
         * @param {Address} ownerAddress Owner address.
         * @param {ulong} nonce Nonce.
         * @returns {ulong} Computed mosaic id.
         */
        public static ulong GenerateMosaicId<T>(T ownerAddress, ulong nonce) where T : ByteArray
        {
            var hasher = new Sha3Digest(256);
            var arr = new byte[32];
            hasher.BlockUpdate(BitConverter.GetBytes(nonce), 0, 4);
            hasher.BlockUpdate(ownerAddress.bytes, 0, ownerAddress.bytes.Length);
            hasher.DoFinal(arr, 0);
            var result = BitConverter.ToUInt64(arr, 0);
            if ((result & NAMESPACE_FLAG) != 0) result -= NAMESPACE_FLAG;
            return result;
        }

        /**
         * Generates a namespace id from a name and an optional parent namespace id.
         * @param {byte[]} name Namespace name.
         * @param {ulong} parentNamespaceId Parent namespace id.
         * @returns {ulong} Computed namespace id.
         */
        public static ulong GenerateNamespaceId(byte[] name, ulong parentNamespaceId = 0)
        {
            var hasher = new Sha3Digest(256);
            var arr = new byte[32];
            hasher.BlockUpdate(BitConverter.GetBytes(parentNamespaceId & 0xFFFFFFFF), 0, 4);
            hasher.BlockUpdate(BitConverter.GetBytes((parentNamespaceId >> 32) & 0xFFFFFFFF), 0, 4);
            hasher.BlockUpdate(name, 0, name.Length);
            hasher.DoFinal(arr, 0);
            var result = BitConverter.ToUInt64(arr, 0);
            return result | NAMESPACE_FLAG;
        }

        public static ulong GenerateUlongKey(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var sha3256Digest = new Sha3Digest(256);
            var sha3256Hash = new byte[sha3256Digest.GetDigestSize()];
            sha3256Digest.BlockUpdate(bytes, 0, bytes.Length);
            sha3256Digest.DoFinal(sha3256Hash, 0);
            var list = new List<byte>(sha3256Hash).GetRange(0, 8);
            list[7] = (byte)(list[7] | 0x80);
            return BitConverter.ToUInt64(list.ToArray(), 0);
        }
    }
}