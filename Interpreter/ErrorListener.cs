using Antlr4.Runtime;

namespace PixelBasic;

public class ErrorListener : BaseErrorListener {
    
    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine,
        string msg, RecognitionException e)
    {
        Console.WriteLine(msg);
    }
}
