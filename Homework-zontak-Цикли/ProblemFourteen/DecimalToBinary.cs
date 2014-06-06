using System;
class DecimalToBinary
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        long result;
        string binary = string.Empty;

        while (num > 0)
        {
            result = num % 2;
            num /= 2;
            binary = result.ToString() + binary;
        }
        Console.WriteLine(binary);
    }
}

