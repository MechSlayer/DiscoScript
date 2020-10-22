using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class FunctionDeclaration : Node
    {
        public Identifier Id { get; }
        public NodesCollection<Identifier> Args { get; }
        public NodesCollection<Node> Body { get; }

        public FunctionDeclaration(Identifier id, NodesCollection<Identifier> args, NodesCollection<Node> body, IToken parseNode) : base(parseNode?.ToPosition())
        {
            Id = id;
            Args = args;
            Body = body;
        }

        public override string ToString()
        {
            return $"función {Id}({string.Join(", ", Args)}) {{\n{Body}\n}}";
        }

        public override Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var function = new Function(Id.Text, Args.AsReadOnly(), Body.AsReadOnly());
            ICompletion<INative> res = new Completion(function);
            scope.DeclareVariable(Id).Set(function);
            return Task.FromResult(res);
        }
    }
}