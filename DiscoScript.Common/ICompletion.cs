namespace DiscoScript.Common
{
    public interface ICompletion <out T>
    {
        public T Result { get; }
    }
}