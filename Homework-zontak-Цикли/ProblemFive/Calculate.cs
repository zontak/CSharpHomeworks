using System;
class Calculate
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int X = int.Parse(Console.ReadLine());
        double factorialOfN = 1;
        double powX = 1;
        double sum = 1;
        for (int i = 1; i <= N; i++)
        {
            factorialOfN *= i;
            powX *= X;
            sum += (factorialOfN / powX);
        }
        Console.WriteLine("S = {0:F5} ", sum);
    }
}
