using System;
using System.IO;

namespace PixelBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage PixelBasicApp <programFile>");
                return;
            }

            var program = File.ReadAllText(args[0]);

            var interpreter = new Interpreter(program);
            interpreter.ExecuteProgram();
        }
    }
}