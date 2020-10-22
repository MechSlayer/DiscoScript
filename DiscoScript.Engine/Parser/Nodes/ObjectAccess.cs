using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;

namespace DiscoScript.Engine.Parser.Nodes
{
    public class ObjectAccess : Node
    {
        public Node Init { get; }
        public ObjectAccess? Previous { get; private set; }
        public ObjectAccess? Next { get; private set; }

        public bool IsFirst => Previous == null;
        public bool IsLast => Next == null;
        public ObjectAccess(Node init, ObjectAccess? next, IToken parseNode) : base(parseNode.ToPosition())
        {
            Init = init;
            Next = next;
            if (next != null)
                next.Previous = this;
        }
        
        public ObjectAccess(Node init, ObjectAccess? next, CodePosition? parseNode) : base(parseNode)
        {
            Init = init;
            Next = next;
            if (next != null)
                next.Previous = this;
        }

        public override string ToString()
        {
            return $"{Init}{(Next != null ? $".{Next}" : "")}";
        }

        public ObjectAccess GetFirst()
        {
            var current = this;
            while (!current!.IsFirst)
                current = current.Previous;
            return current;
        }
        
        public ObjectAccess GetLast()
        {
            var current = this;
            while (!current!.IsLast)
                current = current.Next;
            return current;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            return await ExecuteAsync(scope, null);
        }
        
        public async Task<ICompletion<INative>> ExecuteAsync(Scope scope, PropertyData? obj)
        {
            var node = this;
            if (obj == null)
            {
                obj = new PropertyData(string.Empty, await Init.ExecuteAsync(scope).GetResult(), null!);
                if (IsFirst && IsLast) return new Completion(obj);
                node = Next;
            }

            while (node != null)
            {
                if (!(obj?.Result is IAccessible accessible))
                    throw new NativeException($"'{obj?.Result.GetShowAs()}' no es accesible", node.Position);
                
                if (node.Init is Identifier identifier)
                    obj = accessible.GetProperty(identifier);

                node = node.Next!;
            }
            
            return obj;
        }
    }
}