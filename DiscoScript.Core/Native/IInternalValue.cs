namespace DiscoScript.Core.Native
{
    public interface IInternalValue <out T>
    {
        T GetInternalValue();
    }
}