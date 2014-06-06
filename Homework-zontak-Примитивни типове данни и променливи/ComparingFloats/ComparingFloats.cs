using System;
using System.Linq;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine(" Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(" Enter B: ");
        double b = double.Parse(Console.ReadLine());
        bool equal = Math.Abs ( a - b) < 0.000001;
        Console.WriteLine(" Are number {0} and {1} equal {2}", a, b, equal);
    }
}

