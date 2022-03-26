using System;
using System.IO;
using System.Text;

namespace PixelBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                // For debugging
                args = new[]
                {
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/for_continue.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/for_exit.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/for_simple.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/functions.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/gcd_euclid.bas", // TODO Not working
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/if_else.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/if_simple_false.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/if_simple_true.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/input.bas", // TODO not working
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/let.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/operations.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/print.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/repeat.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/syntax_err.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/type_err.bas",
                    "/Users/jessefreeman/Projects/DotNet/PixelBasic/PixelBasic/Examples/Tests/while.bas"
                };
                
                if (args.Length == 0)
                {
                    Console.WriteLine("Usage PixelBasicApp <programFile>");
                    return;
                }

                var path = args[15];

                var program = File.ReadAllText(path);

                Console.WriteLine("Running program: " + path);
                
                var programStream = new MemoryStream(Encoding.UTF8.GetBytes(program));
            
                var interpreter = new Interpreter(programStream);
                interpreter.run(programStream);
                interpreter.clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}