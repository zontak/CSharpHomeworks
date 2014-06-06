using System;
class TheBiggestOfThreeNums
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max = Math.Max(a, b);
        double maxTwo = Math.Max(max, c);
        Console.WriteLine(maxTwo);
    }
}
