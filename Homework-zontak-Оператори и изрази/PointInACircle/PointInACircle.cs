using System;
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool sqrt = Math.Sqrt(x * x + y * y) <= 2;
        Console.WriteLine(sqrt);
    }
}

