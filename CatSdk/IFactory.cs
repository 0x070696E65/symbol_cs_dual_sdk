namespace CatSdk;

public interface IFactory
{
    public int Size();
    public E Deserialize<E>(byte[] i);
}