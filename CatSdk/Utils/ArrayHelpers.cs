using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CatSdk.Utils
{
    public static class ArrayHelpers
    {
        public static int DeepCompare(object? lhs, object? rhs)
        {
            return 0;
        }
        private static void AddPadding(int size, BinaryWriter bw,
            int alignment)
        {
            var padding = GetPadding(size, alignment);
            while (padding > 0)
            {
                bw.Write((byte)0);
                padding--;
            }
        }

        private static int GetPadding(int size, int alignment)
        {
            if (alignment == 0)
            {
                return 0;
            }
            return 0 == size % alignment ? 0 : alignment - (size % alignment);
        }

        private static void SkipPadding(int size, BinaryReader dataInputStream, int alignment)
        {
            var padding = GetPadding(size, alignment);
            dataInputStream.BaseStream.Position += padding;
        }

        public static void WriteArray<T>(BinaryWriter bw, IEnumerable<T> elements) where T : ISerializer
        {
            foreach (var t in elements)
            {
                bw.Write(t.Serialize());
                AddPadding((int)t.Size, bw, 0);
            }
        }

        /**
	     * Calculates aligned size.
	     * @param {uint} size Size.
	     * @param {uint} alignment Alignment.
	     * @returns {uint} Size rounded up to alignment.
	     */
        private static uint AlignUp(uint size, uint alignment)
        {
            return (uint)Math.Floor((size + alignment - 1) / (float)alignment) * alignment;
        }

        /**
	     * Calculates size of variable size objects.
	     * @param {array&lt;T&gt;} elements Serializable elements.
	     * @param {uint} alignment Alignment used for calculations.
	     * @param {bool} skipLastElementPadding true if last element should not be aligned.
	     * @returns {uint} Computed size.
	     */
        public static uint Size<T>(T[] elements, uint alignment = 0, bool skipLastElementPadding = false) where T : ISerializer
        {
            if (alignment == 0) return (uint)elements.Sum((e) => e.Size);

            if (!skipLastElementPadding) return (uint)elements.Sum((e) => AlignUp(e.Size, alignment));

            var sum = elements.Take(elements.Length - 1).Sum((e) => e.Size);
            return (uint)(sum + elements[elements.Length - 1].Size);
        }

        /**
	     * Writes array of variable size objects.
	     * @param {BinaryWriter} output An output sink.
	     * @param {array&lt;T&gt;} elements Serializable elements.
	     * @param {uint} alignment Alignment used to make sure each object is at boundary.
	     * @param {bool} skipLastElementPadding true if last element should not be aligned/padded.
	     */
        public static void WriteVariableSizeElements<T>(BinaryWriter bw, T[] elements, uint alignment, bool skipLastElementPadding = false) where T : ISerializer
        {
            for (var i = 0; i < elements.Length; i++)
            {
                bw.Write(elements[i].Serialize().ToArray());
                if (skipLastElementPadding && elements.Length - 1 == i) continue;
                var alignedSize = AlignUp(elements[i].Size, alignment);
                if (alignedSize != elements[i].Size)
                {
                    bw.Write(new byte[alignedSize - elements[i].Size]);
                }
            }
        }

        /**
	     * Reads array of variable size objects.
	     * @param {BinaryReader} bufferInput A uint8 array.
	     * @param {Func} FactoryClass Factory used to deserialize objects.
	     * @param {uint} alignment Alignment used to make sure each object is at boundary.
	     * @param {bool} skipLastElementPadding true if last element is not aligned/padded.
	     * @returns {array&lt;T&gt;} Array of deserialized objects.
	     */
        public static T[] ReadVariableSizeElements<T>(BinaryReader br, Func<BinaryReader, T> factory, uint payloadSize, int alignment, bool skipLastElementPadding = false) where T : ISerializer
        {
            var elements = new List<T>();
            if (alignment == 0) return elements.ToArray();
            var remainingByteSizes = (int)payloadSize;
            while (remainingByteSizes > 0)
            {
                var entity = factory(br);
                elements.Add(entity);
                var size = (int)entity.Size;
                var itemSize = size + GetPadding(size, alignment);
                remainingByteSizes -= itemSize;
                SkipPadding(size, br, alignment);
            }
            return elements.ToArray();
        }

        /**
	     * Reads array of objects.
	     * @param {BinaryReader} bufferInput Input buffer.
	     * @param {Func} accessor Optional accessor used to check objects order.
	     * @returns {array&lt;T&gt;} Array of deserialized objects.
	     */
        public static T[] ReadArray<T>(BinaryReader br, Func<BinaryReader, T> factory) where T : ISerializer
        {
            var position = br.BaseStream.Position;
            var length = (int)br.BaseStream.Length;
            var elements = new List<T>();
            if (length == position) return elements.ToArray();
            while (br.BaseStream.Position < length)
            {
                var entity = factory(br);
                elements.Add(entity);
            }
            return elements.ToArray();
        }

        /**
	     * Reads array of deterministic number of objects.
	     * @param {BinaryReader} bufferInput A uint8 array.
	     * @param {Func} accessor Optional accessor used to check objects order.
         * @param {byte} count Number of object to deserialize.
	     * @returns {array&lt;T&gt;} Array of deserialized objects.
	     */
        public static T[] ReadArrayCount<T>(BinaryReader br, Func<BinaryReader, T> factory, byte count) where T : ISerializer
        {
            var alignment = br.BaseStream.Length;
            var elements = new List<T>();
            if (alignment == 0) return elements.ToArray();
            for (var i = 0; i < count; i++)
            {
                var entity = factory(br);
                elements.Add(entity);
            }
            return elements.ToArray();
        }
    }
}