using System;
using System.Numerics;
class Catalan
{
    static void Main()
    {
        Console.Write(" Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else if (n == 0 || n == 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            BigInteger first = 1;
            BigInteger second = 2;
            for (int i = 2 * n; i < n + 1; i--)
            {
                first *= i;
            }
            for (int i = n; i < 1; i--)
            {
                second *= i;
            }
            BigInteger result = first / second;
            Console.WriteLine(result);
        }
    }
}

