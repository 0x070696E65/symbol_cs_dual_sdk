namespace CatSdk;

public interface IEnum<out T>: ISerializer
{
    public T Value{ get; }
}