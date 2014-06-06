using System;
class BitWise
{
    static void Main()
    {
        Console.Write(" Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int number = (mask & n);
        bool IsPositive = number > 0;
        Console.WriteLine(IsPositive);
    }
}
