using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;
        Console.WriteLine("{0:0.00}", perimeter);
        Console.WriteLine("{0:0.00}", area);
    }
}
