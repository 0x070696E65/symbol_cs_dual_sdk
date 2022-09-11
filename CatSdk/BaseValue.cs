namespace CatSdk;

public abstract class BaseValue
{
    public uint Size { get; }
    public readonly ulong Value;

    protected BaseValue(byte size, ulong value)
    {
        Size = size;
        Value = value;
    }
    
    public override string ToString()
    {
        return "0x" + $"{Value:X}".PadLeft((int)Size * 2, '0');
    }
}