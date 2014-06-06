using System;
class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());


        decimal nPon = n * n;
        decimal mPop = m * p;
        decimal firstLine = nPon + (1 / mPop) + 1337;
        decimal secondLine = n - (128.523123123m * p);
        decimal mmm = firstLine / secondLine;
        int mod = (int)m % 180;
        double sin = Math.Sin((double)mod);
        decimal result = mmm + (decimal)sin;
        Console.WriteLine("{0:F6}", result);
    }
}

