namespace PixelBasic;

public class Utils
{
    public static String FormatErrorMessage(int line, int posInLine, String message) {
        return "Error at [" + line + ", " + posInLine + "]: " + message;
    }
}