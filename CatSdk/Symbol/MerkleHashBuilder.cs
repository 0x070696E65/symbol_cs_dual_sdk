using System;
using System.Collections.Generic;
using NUnit.Framework;
using Org.BouncyCastle.Crypto.Digests;

namespace CatSdk.Symbol
{
    /**
     * Builder for creating a merkle hash.
     */
    public class MerkleHashBuilder
    {
        public readonly List<byte[]> hashes;

        public MerkleHashBuilder()
        {
            hashes = new List<byte[]>();
        }

        /**
	     * Adds a hash to the merkle hash.""
	     * @param {Hash256} componentHash Hash to add.
	     */
        public void Update(Hash256 componentHash)
        {
            hashes.Add(componentHash.bytes);
        }

        /**
	     * Calculates the merkle hash.
	     * @returns {Hash256} Merkle hash.
	     */
        public Hash256 Final()
        {
            if (0 == hashes.Count)
                return new Hash256();

            var numRemainingHashes = hashes.Count;
            while (1 < numRemainingHashes)
            {
                var i = 0;
                while (i < numRemainingHashes)
                {
                    var hasher = new Sha3Digest(256);
                    hasher.BlockUpdate(hashes[i], 0, hashes[i].Length);

                    if (i + 1 < numRemainingHashes)
                    {
                        hasher.BlockUpdate(hashes[i + 1], 0, hashes[i + 1].Length);
                    }
                    else
                    {
                        // if there is an odd number of hashes, duplicate the last one
                        hasher.BlockUpdate(hashes[i], 0, hashes[i].Length);
                        numRemainingHashes += 1;
                    }

                    hasher.DoFinal(hashes[(int)Math.Truncate(i / 2.0f)], 0);
                    i += 2;
                }

                numRemainingHashes = (int)Math.Truncate(numRemainingHashes / 2.0f);
            }

            return new Hash256(hashes[0]);
        }
    }
}