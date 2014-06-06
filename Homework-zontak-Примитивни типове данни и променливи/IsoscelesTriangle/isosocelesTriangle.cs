using System;
using System.Linq;
using System.Text;

class isosocelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char c = '\u00A9';
        Console.WriteLine("          " + c + "           ");
        Console.WriteLine("        " + c + "   " + c + "     ");
        Console.WriteLine("      " + c + "       " + c + "       ");
        Console.WriteLine("    " + c + "   " + c + "   " + c + "   " + c);
    }
}

