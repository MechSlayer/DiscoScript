using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class VarDeclaration : Node
    {
        public Identifier Id { get; }
        public Node? Init { get; }

        public VarDeclaration(Identifier id, Node? init, IToken parseNode) : base(parseNode?.ToPosition())
        {
            Id = id;
            Init = init;
        }

        public override string ToString()
        {
            return $"var {Id} {(Init != null ? $"= {Init}" : "")}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            scope.DeclareVariable(Id);
            var init = Init == null ? new Undefined() : (await Init.ExecuteAsync(scope)).Result;
            scope.AssignVariable(Id, init);
            return new Completion(init);
        }
    }
}