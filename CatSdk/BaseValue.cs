namespace CatSdk;

public abstract class BaseValue
{
    public uint Size { get; set; }
    public readonly ulong Value;

    protected BaseValue(byte size, ulong value)
    {
        Size = size;
        Value = value;
    }
    
    public override string ToString()
    {
        ulong unsignedValue;
        if (true)
        {
            unsignedValue = Value;
        }
        else
        {
            var upper_bound_plus_one = (uint)1 << ((int)Size * 8);
            unsignedValue = Value + upper_bound_plus_one;
        }
        return "0x" + $"{unsignedValue:X}".PadLeft((int)Size * 2, '0');
    }
}