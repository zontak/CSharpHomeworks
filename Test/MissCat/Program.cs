using System;
using System.Linq;
using System.Collections.Generic;

class test
{
static void Main()
{
    uint n = uint.Parse(Console.ReadLine());
        int[] masiv = new int[11];
        for (int i = 1; i <= 10; i++)
        {
            masiv[i] = 0;
        }
        for (int i = 1; i <= n; i++)
        {
            int res = int.Parse(Console.ReadLine());
            masiv[res] += 1;
        }
        Console.WriteLine(Array.IndexOf(masiv, masiv.Max()));
    }
}