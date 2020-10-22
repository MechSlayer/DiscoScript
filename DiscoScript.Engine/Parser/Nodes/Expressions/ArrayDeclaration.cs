using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class ArrayDeclaration : Node
    {
        public NodesCollection<Node> Elements { get; }

        public ArrayDeclaration(NodesCollection<Node> elements, IToken parseNode) : base(parseNode.ToPosition())
        {
            Elements = elements;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", Elements)}]";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var array = new Objects.Array();
            foreach (var element in Elements)
                array.Add(await element.ExecuteAsync(scope).GetResult());

            return new Completion(array);
        }
    }
}