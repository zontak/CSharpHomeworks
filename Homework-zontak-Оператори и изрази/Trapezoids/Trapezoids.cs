using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine(" Submit A ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(" Submit B ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(" Submit H ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}
