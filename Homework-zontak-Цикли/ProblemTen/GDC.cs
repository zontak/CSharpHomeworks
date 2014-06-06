using System;
public class GDC
{
    static int GCD(int a, int b)
    {
        int Remainder;
        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        return a;
    }
    static int Main()
    {
        int x, y;
        Console.WriteLine("This program allows calculating the GCD");
        Console.Write("Value 1: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Value 2: ");
        y = int.Parse(Console.ReadLine());
        Console.Write("\nThe Greatest Common Divisor of ");
        Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));
        return 0;
    }
}