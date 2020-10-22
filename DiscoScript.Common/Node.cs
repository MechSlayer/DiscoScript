using System.Threading.Tasks;

namespace DiscoScript.Common
{
    public abstract class Node <TReturn, TScope>
    {
        public CodePosition? Position { get; }

        public Node(CodePosition? position)
        {
            Position = position;
        }

        public override string ToString()
        {
            return $"Node {Position}";
        }

        public abstract Task<ICompletion<TReturn>> ExecuteAsync(TScope scope);

        public T2 As<T2>()
        {
            if (this is T2 t2) return t2;
            return default!;
        }
        public bool Is<T2>() => this is T2;
    }
}