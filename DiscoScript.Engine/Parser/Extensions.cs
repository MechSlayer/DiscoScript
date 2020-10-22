using System.Collections.Generic;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser
{
    public static class Extensions
    {
        public static CodePosition ToPosition(this IToken token) => new CodePosition(token.Line, token.Column);
    }
}