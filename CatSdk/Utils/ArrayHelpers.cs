namespace CatSdk.Utils;

public static class ArrayHelpers
{
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
    
    public static void WriteArray<T>(BinaryWriter bw, IEnumerable<T> elements) where T: ISerializer
    {
        foreach (var t in elements)
        {
            bw.Write(t.Serialize());
            AddPadding((int)t.Size, bw, 0);
        }
    }

    private static uint AlignUp(uint size, uint alignment)
    {
        return (uint)Math.Floor((size + alignment - 1) / (float)alignment) * alignment;
    }
    
    public static uint Size<T>(T[] elements, uint alignment = 0, bool skipLastElementPadding = false) where T: ISerializer
    {
        if (alignment == 0) return (uint) elements.Sum((e) => e.Size);
        
        if (!skipLastElementPadding) return (uint) elements.Sum((e) => AlignUp(e.Size, alignment));
        
        var sum = elements.Take(elements.Length - 1).Sum((e) => e.Size);
        return (uint) (sum + elements[^1].Size);
    }
    
    public static void WriteVariableSizeElements<T>(BinaryWriter bw, T[] elements, uint alignment, bool skipLastElementPadding = false) where T: ISerializer {
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
    
    public static T[] ReadVariableSizeElements<T>(BinaryReader br, Func<BinaryReader, T> factory, uint payloadSize, int alignment, bool skipLastElementPadding = false) where T: ISerializer
    {
        var elements = new List<T>();
        if (alignment == 0) return elements.ToArray();
        var remainingByteSizes = (int)payloadSize;
        while (remainingByteSizes > 0){
            var entity = factory(br);
            elements.Add(entity);
            var size = (int)entity.Size;
            var itemSize = size + GetPadding(size, alignment);
            remainingByteSizes -= itemSize;
            SkipPadding(size, br, alignment);
        }
        return elements.ToArray();
    }
    
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