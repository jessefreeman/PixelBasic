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
                if (args.Length != 1)
                {
                    Console.WriteLine("Usage PixelBasicApp <programFile>");
                    return;
                }

                var program = File.ReadAllText(args[0]);

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