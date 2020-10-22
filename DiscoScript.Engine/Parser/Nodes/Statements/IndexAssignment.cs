using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Engine.Parser.Nodes.Expressions;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class IndexAssignment : Node
    {
        public Node Target { get; }
        public Node Index { get; }
        public string Operator { get; }
        public Node Init { get; }
        public IndexAssignment(Node target, Node index, string op, Node init, IToken? position) : base(position?.ToPosition())
        {
            Target = target;
            Index = index;
            Operator = op;
            Init = init;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var target = await Target.ExecuteAsync(scope).GetResult();
            if (!(target is IIndexAccesible indexAccesible))
                throw new NativeException($"'{target.GetShowAs()}' no dispone de índice");

            var index = await Index.ExecuteAsync(scope).GetResult();
            var value = indexAccesible[index];
            var newValue = BinaryOperation.Execute(value, Operator, await Init.ExecuteAsync(scope).GetResult());
            indexAccesible[index] = newValue;
            return new Completion(newValue);
        }
    }
}