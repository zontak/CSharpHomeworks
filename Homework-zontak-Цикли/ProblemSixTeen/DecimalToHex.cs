using System;
class DecimalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string number = string.Empty;

        while (input != 0)
        {
            long mmm = input % 16;
            input /= 16;
            switch (mmm)
            {
                case 10: number += 'A'; break;
                case 11: number += 'B'; break;
                case 12: number += 'C'; break;
                case 13: number += 'D'; break;
                case 14: number += 'E'; break;
                case 15: number += 'F'; break;
                default: number = number + mmm; break;
            }
        }

        string result = "";
        for (int i = 0; i < number.Length; i++)
        {
            result = number[i] + result;
        }

        Console.WriteLine(result);
    }
}

