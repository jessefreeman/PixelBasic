using Antlr4.Runtime;

namespace PixelBasic
{

    public class Interpreter
    {
        private MemoryStream stdin;
        // private OutputStream stdout;
        // private OutputStream stderr;
        // private PrintStream stdoutPrint;
        // private PrintStream stderrPrint;
        private Memory memory;

        public Interpreter(MemoryStream stdin)//, OutputStream stdout, OutputStream stderr)
        {
            this.stdin = stdin;
            // this.stdout = stdout;
            // this.stderr = stderr;
            // this.stdoutPrint = new PrintStream(stdout, true);
            // this.stderrPrint = new PrintStream(stderr, true);
        }

        public Value run(MemoryStream progrIn)
        {
            // throws IOException {

            var input = new AntlrInputStream(progrIn);
            var lexer = new PixelBasicLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new PixelBasicParser(tokens);
            
            
            parser.ErrorHandler = new BailErrorStrategy();
            parser.RemoveErrorListener(null); // TODO not sure what to pass into this            
            parser.ErrorListeners.Add(new ErrorListener());
            
            // parser.setErrorHandler(new BailErrorStrategy());
            // parser.removeErrorListeners();
            // parser.addErrorListener(new ErrorListener(stderrPrint));
            try
            {
                var tree = parser.prog();
                memory = new Memory();
                var eval = new PixelBasicVisitor(memory, stdin);//, stdoutPrint, stderrPrint);
                eval.Visit(tree);
            }
            catch (Exception e)
            {
                if (e is InputMismatchException)
                {
                    var inputEx = (InputMismatchException) e;//.getCause();
                    String msg = Utils.FormatErrorMessage(
                        inputEx.OffendingToken.Line,
                        inputEx.OffendingToken.StartIndex,
                        "Syntax error");
            
                    Console.WriteLine(msg);
                }
                else
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
                
            }
            // catch (InterpreterException e)
            // {
            //     Console.WriteLine(e.Message);
            //     // stderrPrint.println(e.getMessage());
            // }
            // catch (Exception e) // ParseCancellationException
            // {
            //     if (e is InputMismatchException)
            //     {
            //
            //         var inputEx = (InputMismatchException) e;//.getCause();
            //         String msg = Utils.FormatErrorMessage(
            //         inputEx.OffendingToken.Line,
            //         inputEx.OffendingToken.StartIndex,
            //         "Syntax error");
            //         
            //         Console.WriteLine(msg);
            //         // stderrPrint.println(msg);
            //     }
            // }

            return null;
        }

        public Memory getMemory()
        {
            return memory;
        }

        public void clear()
        {
            // memory.free();
        }

    }
}