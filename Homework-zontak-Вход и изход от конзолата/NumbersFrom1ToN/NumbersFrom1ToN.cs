using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter value; ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
