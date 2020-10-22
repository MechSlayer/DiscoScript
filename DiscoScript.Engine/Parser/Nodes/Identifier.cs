using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes
{
    public class Identifier : Node
    {
        public string Text { get; }

        public Identifier(string text, IToken parseNode) : base(parseNode.ToPosition())
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }

        public override Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            ICompletion<INative> res = scope.FindVariable(this);
            return Task.FromResult(res);
        }

        public static implicit operator string(Identifier id) => id.Text;
    }
}