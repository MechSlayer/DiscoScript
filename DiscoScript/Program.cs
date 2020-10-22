using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;
using DiscoScript.Engine.Core;
using Newtonsoft.Json;
using Serilog;

namespace DiscoScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.Console()
                .CreateLogger();

            if (args.Length == 0)
            {
                RunInterpreter();
                return;
            }

            var input = File.ReadAllText(args[0]);
            var engine = new ScriptEngine();
            engine.ExecuteAsync(input).GetAwaiter().GetResult();
        }

        static void RunInterpreter()
        {
            var input = string.Empty;

            var engine = new ScriptEngine();
            while (input != "salir")
            {
                Console.Write(">");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine();
                    continue;
                }
                var result = engine.ExecuteAsync(input!).GetAwaiter().GetResult();
                Console.WriteLine(result.Result);
            }
        }
    }
}