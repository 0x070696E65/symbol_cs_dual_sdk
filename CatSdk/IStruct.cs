namespace CatSdk;

public interface IStruct : ISerializer
{
    public Dictionary<string, string> TypeHints { get; }
}