using System;
using System.Linq;

class quotesInString
{
    static void Main()
    {
        string name = @"The ""use"" of quotations causes difficulties. ";
        string nameTwo = "The \"use\" of quotations causes difficulties. ";
        Console.WriteLine(name);
        Console.WriteLine(nameTwo);
    }
}

