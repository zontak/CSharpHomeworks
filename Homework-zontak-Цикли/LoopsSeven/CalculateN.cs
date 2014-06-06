using System;
class CalculateN
{
    static void Main(string[] args)
    {
    START:
        Console.Write("N: ");
        double N = double.Parse(Console.ReadLine());
        Console.Write("K: ");
        double K = double.Parse(Console.ReadLine());
        double NminusK = N - K;
        double factorialOfN = 1;
        double factorialOfK = 1;
        double factorielSubN = 1;
        if (K < 1 || N < K || N > 100)
        {
            Console.WriteLine(" Invalid input ");
            goto START;
        }
        else
        {
            for (int nn = 1; nn <= N; nn++)
            {
                factorialOfN *= nn;
            }
            for (int kk = 1; kk <= K; kk++)
            {
                factorialOfK *= kk;
            }
            for (int nk = 1; nk <= NminusK; nk++)
            {
                factorielSubN *= nk;
            }
        }
        double result = factorialOfN / (factorialOfK * factorielSubN);
        Console.WriteLine(result);
    }
}

