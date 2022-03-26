using Antlr4.Runtime.Misc;

namespace PixelBasic;

public class InterpreterException : Exception // extends RuntimeException?
{

    private int line;
    private int posInLine;
    
    public InterpreterException(string message) : base(message)
    {
    }

    public void SetLocation(int line, int posInLine)
    {
        this.line = line;
        this.posInLine = posInLine;
    }

    public override string Message => Utils.FormatErrorMessage(line, posInLine, base.Message);
    
}