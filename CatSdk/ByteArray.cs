using CatSdk.Utils;

namespace CatSdk
{
    public abstract class ByteArray
    {
        public uint Size { get; }
        public byte[] bytes { get; }

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
    
        protected ByteArray(int fixedSize, string hexstring)
        {
            var rawBytes = Converter.HexToBytes(hexstring);
            if (fixedSize != rawBytes.Length) throw new Exception($"bytes was size {rawBytes.Length} but must be {fixedSize}");
            bytes = rawBytes;
        }

        public override string ToString()
        {
            return Converter.BytesToHex(bytes);
        }
    }
}