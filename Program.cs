using System;
using System.Diagnostics;
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

                string path;
                
                if (args.Length == 0)
                {
                    Console.WriteLine("Usage PixelBasicApp <programFile>");
                    
                    // These are used for debugging if a file's path is not provided
                    
                    var rootPath = $"..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}..{Path.DirectorySeparatorChar}";

                    // For debugging
                    args = new[]
                    {
                        "for_continue.bas",
                        "for_exit.bas",
                        "for_simple.bas",
                        "functions.bas",
                        "gcd_euclid.bas", // TODO Not working
                        "if_else.bas",
                        "if_simple_false.bas",
                        "if_simple_true.bas",
                        "input.bas", // TODO not working
                        "let.bas",
                        "operations.bas",
                        "print.bas",
                        "repeat.bas",
                        "syntax_err.bas",
                        "type_err.bas",
                        "while.bas"
                    };
                    
                    path = Path.Combine(rootPath, "Examples", args[0]);
                }
                else
                {
                    path = args[0];
                }
                
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