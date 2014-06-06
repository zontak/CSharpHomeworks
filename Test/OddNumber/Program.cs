using System;
class Program
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long result = 0;
        long[] masiv = new long[number];
        for (int i = 0; i < masiv.Length; i++)
        {
            masiv[i] = long.Parse(Console.ReadLine());
            result ^= masiv[i];
        }
        Console.WriteLine(result);
    }
}

