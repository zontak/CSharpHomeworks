using System;

class exchangeVariable
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);
        int c = b;
        b = a;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

