using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write(" A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write(" B: ");
        double B = double.Parse(Console.ReadLine());
        Console.Write(" C: ");
        double C = double.Parse(Console.ReadLine());
        double descreminantD = (( B * B ) - ( 4 * A * C));
        double rootOne;
        double rootTwo;
        if ( descreminantD > 0)
        {
            rootOne = (- B + Math.Sqrt(descreminantD)) / (2 * A);
            rootTwo = (- B - Math.Sqrt(descreminantD)) / (2 * A);
            Console.WriteLine(" Two real roots ");
            Console.WriteLine("Root One = {0:F1} ", rootOne);
            Console.WriteLine("Root Two = {0:F1} ", rootTwo);
        }
        else if ( descreminantD == 0)
        {
            Console.WriteLine(" One real root ");
            rootOne = rootTwo = (-B - Math.Sqrt(descreminantD)) / (2 * A);
            Console.WriteLine("Root One = Root Two = {0:F1} ", rootOne);
        }
        else if ( descreminantD < 0)
        {
            Console.WriteLine(" No real roots ");
        }
    }
}
