using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Engine.Parser.Nodes.Expressions;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class AssignmentNode : Node
    {
        public Node Target { get; }
        public string Operator { get; }
        public Node Init { get; }

        public AssignmentNode(Node target, string @operator, Node init, IToken parseNode) : base(parseNode.ToPosition())
        {
            Target = target;
            Operator = @operator;
            Init = init;
        }

        public override string ToString()
        {
            return $"{Target} {Operator} {Init}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var target = await Target.ExecuteAsync(scope).As<PropertyData>();
            if (target.Result.IsUndefined())
                throw new NativeException($"'{Target}' no está definido", Position);

            var newRes = BinaryOperation.Execute(target.Result, Operator,
                await Init.ExecuteAsync(scope).GetResult());
            
            target.Set(newRes);
            return new Completion(newRes);
        }
    }
}