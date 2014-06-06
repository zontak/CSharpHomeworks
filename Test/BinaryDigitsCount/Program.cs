using System;
using System.Linq;
using System.Collections.Generic;

class BinaryDigitsCount
{
    static void Main()
    {
        int binary = int.Parse(Console.ReadLine());
        long digit = long.Parse(Console.ReadLine());

        long[] digits = new long[digit];
        int[] counter = new int[digit];
        for (int i = 0; i < digit; i++)
        {
            digits[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 0; i < digits.Length; i++)
        {
            string s = Convert.ToString(digits[i], 2);

            int[] bits = s.Select(c => int.Parse(c.ToString())).ToArray();
            for (int j = 0; j < bits.Length; j++)
            {
                if (binary == bits[j])
                {
                    counter[i]++;
                }
            }
        }
        foreach (var cnt in counter)
        {
            Console.WriteLine(cnt);
        }
    }
}