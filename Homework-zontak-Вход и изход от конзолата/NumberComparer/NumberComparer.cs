using System;
class NumberComparer
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = Math.Max(a, b);
        Console.WriteLine(c);
    }
}
