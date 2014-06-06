using System;
class ProblemEighteen
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int zeroCount = 0;
        double factorialOfNumber = 1;
        int divider;
        for (int i = 1; i <= number; i++)
        {
            factorialOfNumber *= i;
        }
        Console.WriteLine("Factoriel is: " + factorialOfNumber);
        for (int i = 5; i <= number; i += 5)
        {
            divider = i;
            while (divider % 5 == 0)
            {
                divider /= 5;
                zeroCount++;
            }
        }
        Console.WriteLine("Zero`s: " + zeroCount);
    }
}

