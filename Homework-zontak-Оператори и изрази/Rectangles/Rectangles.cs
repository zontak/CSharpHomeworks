using System;
class Rectangles
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double area = a * b;
        double perimeter = (a * 2) + (b * 2);
        Console.WriteLine(" Area is: {0} ", area);
        Console.WriteLine(" Perimeter is: {0} ", perimeter);
    }
}
