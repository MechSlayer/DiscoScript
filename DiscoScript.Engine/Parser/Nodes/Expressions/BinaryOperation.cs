using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class BinaryOperation : Node
    {
        public Node Left { get; }
        public string Operator { get; }
        public Node Right { get; }

        public BinaryOperation(Node left, string @operator, Node right, IToken parseNode) : base(parseNode.ToPosition())
        {
            Left = left;
            Operator = @operator;
            Right = right;
        }


        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var left = await Left.ExecuteAsync(scope).GetResult();
            var right = await Right.ExecuteAsync(scope).GetResult();
            var res = Execute(left, Operator, right);
            return new Completion(res);
        }

        public static INative Execute(INative left, string op, INative right)
        {
            return op switch
            {
                "==" => Helpers.CompareEquality(left, op, right),
                "!=" => Helpers.CompareEquality(left, op, right),
                "<" => Helpers.CompareEquality(left, op, right),
                ">" => Helpers.CompareEquality(left, op, right),
                "<=" => Helpers.CompareEquality(left, op, right),
                ">=" => Helpers.CompareEquality(left, op, right),
                "+" => left + right,
                "+=" => left + right,
                "-" => left - right,
                "-=" => left - right,
                "*" => left * right,
                "*=" => left * right,
                "/" => left / right,
                "/=" => left / right,
                "&&" => (left.ToBool() && right.ToBool()).ToNative(),
                "||" => (left.ToBool() || right.ToBool()).ToNative(),
                "=" => right,
                _ => Number.NaN
            };
        }

        public override string ToString()
        {
            return $"{Left} {Operator} {Right}";
        }
    }
}