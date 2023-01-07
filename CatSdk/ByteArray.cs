using System;
using CatSdk.Utils;

namespace CatSdk
{
    /**
     * Represents a fixed size byte array.
     */
    public abstract class ByteArray
    {
        public uint Size { get; }
        public byte[] bytes { get; }

        /**
	     * Creates a byte array.
	     * @param {byte} fixedSize Size of the array.
	     * @param {byte[]?} arrayInput Byte array.
	     */
        protected ByteArray(byte fixedSize, byte[]? arrayInput)
        {
            Size = fixedSize;
            if (arrayInput == null)
            {
                bytes = new byte[fixedSize];
            }
            else
            {
                if (fixedSize != arrayInput.Length) throw new Exception($"bytes was size {arrayInput.Length} but must be {fixedSize}");
                bytes = arrayInput;
            }
        }

        /**
	     * Creates a byte array.
	     * @param {byte} fixedSize Size of the array.
	     * @param {string} arrayInput hex string.
	     */
        protected ByteArray(int fixedSize, string hexstring)
        {
            var rawBytes = Converter.HexToBytes(hexstring);
            if (fixedSize != rawBytes.Length) throw new Exception($"bytes was size {rawBytes.Length} but must be {fixedSize}");
            bytes = rawBytes;
        }

        /**
	     * Returns string representation of this object.
	     * @returns {string} String representation of this object
	     */
        public override string ToString()
        {
            return Converter.BytesToHex(bytes);
        }
    }
}