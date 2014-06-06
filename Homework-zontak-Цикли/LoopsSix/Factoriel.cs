using System;
class Factoriel
{
    static void Main(string[] args)
    {
        START:
        Console.Write(" Enter N: ");
        double N = double.Parse(Console.ReadLine());
        Console.Write(" Enter K: ");
        double K = double.Parse(Console.ReadLine());
        double factorialOfN = 1;
        double factorialOfK = 1;
        if (K < 0 || N < K || N > 1000 || K > N)
        {
            Console.WriteLine(" Invalid input ");
            goto START;
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                factorialOfN *= i;
            }
            for (int r = 1; r <= K; r++)
            {
                factorialOfK *= r;
            }
        }
        Console.WriteLine("N! = {0}", factorialOfN);
        Console.WriteLine("K! = {0}", factorialOfK);
        double math = factorialOfN / factorialOfK;
        Console.WriteLine("N!/K! = {0}", math);
    }
}

