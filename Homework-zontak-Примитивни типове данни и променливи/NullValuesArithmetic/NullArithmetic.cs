using System;
using System.Linq;

class NullArithmetic
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = null;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        firstNumber += 7;
        secondNumber += 3.5;
        Console.WriteLine("add values");
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
    }
}

