using Antlr4.Runtime.Misc;

namespace DiscoScript.Engine.Parser
{
    public class ParsingException : ParseCanceledException
    {
        public ParsingException(string message) : base(message)
        {
            
        }
    }
}