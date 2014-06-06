using System;
class MinMaxSumAndAverage
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(Console.ReadLine());
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }
        double sum = max + min;
        double average = sum / 2;
        Console.WriteLine("Smallest: " + min);
        Console.WriteLine("Biggest: " + max);
        Console.WriteLine("Their sum is " + sum);
        Console.WriteLine("Average: {0:F2} ", +average);
    }
}
