using System.IO;
using Antlr4.Runtime;
using DiscoScript.Common.Exceptions;

namespace DiscoScript.Engine.Parser
{
    public class ParseErrorListener : BaseErrorListener
    {
        public static readonly ParseErrorListener Instance = new ParseErrorListener();
        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
            string msg, RecognitionException e)
        {
            throw new NativeException("línea " + line + ":" + charPositionInLine + " " + msg);
        }
    }
}