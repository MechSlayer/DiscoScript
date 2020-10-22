namespace DiscoScript.Core.Native.Objects
{
    public interface IIndexAccesible
    {
        INative this[INative key] { get; set; }
    }
}