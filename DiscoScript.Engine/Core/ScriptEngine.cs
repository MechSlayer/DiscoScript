using System;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Core
{
    public class ScriptEngine
    {
        public GlobalScope GlobalScope { get; }
        private Parser.Parser _parser;

        public ScriptEngine()
        {
            _parser = new Parser.Parser();
            GlobalScope = new GlobalScope();
        }

        public async Task<ICompletion<INative>> ExecuteAsync(string code)
        {
            try
            {
                var result = _parser.Parse(code);
                var completion = await result.ExecuteAsync(GlobalScope);
                return completion;
            }
            catch (NativeException e)
            {
                Console.WriteLine($"Ha ocurrido un error: {e.Message}, {e.Position?.Line}-{e.Position?.Column}");
            }
            return new Completion();
        }


    }
}