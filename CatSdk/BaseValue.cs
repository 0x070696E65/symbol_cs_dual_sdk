namespace CatSdk;

/**
 * Represents a base integer.
 */
public abstract class BaseValue
{
    public uint Size { get; }
    public readonly ulong Value;

    /**
     * Creates a base value.
     * @param {byte} size Size of the integer.
     * @param {ulong} value Value.
     */
    protected BaseValue(byte size, ulong value)
    {
        Size = size;
        Value = value;
    }
    
    /**
	 * Converts base value to string.
	 * @returns {string} String representation.
	 */
    public override string ToString()
    {
        return "0x" + $"{Value:X}".PadLeft((int)Size * 2, '0');
    }
}