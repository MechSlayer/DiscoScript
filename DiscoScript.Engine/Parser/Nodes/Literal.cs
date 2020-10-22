using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Engine.Parser.Lexer;


namespace DiscoScript.Engine.Parser.Nodes
{
    public class Literal : Node
    {
        public object? Value { get; }

        public Literal(TParser.LiteralContext ctx, IToken parseNode) : base(parseNode.ToPosition())
        {
            var token = ctx.Start;
            Value = token.Type switch
            {
                TParser.StringLiteral => token.Text.Substring(1, token.Text.Length - 2),
                TParser.BooleanLiteral => token.Text == "verdadero",
                TParser.DecimalLiteral => double.Parse(token.Text),
                TParser.NaN => double.NaN,
                TParser.NullLiteral => null,
                _ => null
            };
        }

        public Literal(object? value, IToken parseNode) : base(parseNode.ToPosition())
        {
            Value = value;
        }

        public override Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            ICompletion<INative> result = new Completion(Value.ToNative());
            return Task.FromResult(result);
        }

        public override string ToString()
        {
            return Value?.ToString() ?? string.Empty;
        }
    }
}