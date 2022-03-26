using System.Text;

namespace PixelBasic;

public class OutputStream : TextWriter
{
    public override Encoding Encoding { get; }
}