using System;
class PointInsideACircleAndOutside
{
    static void Main()
    {
        Console.WriteLine(" submit x ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(" submit y ");
        double y = double.Parse(Console.ReadLine());
        bool sqrt = (x - 1) * (x - 1 ) + ( y - 1 ) * ( y - 1 ) <= (1.5 * 1.5);
        bool rectangle = x >= 1 || x <= 5 && y >= -1 || y <= 1;
        if (x == 0 || y == 0)
        {
            Console.WriteLine(" no ");
        }
        if ( sqrt == true && rectangle == true )
        {
            Console.WriteLine(" yes ");
        }
        else 
        {
            Console.WriteLine(" no ");
        }
    }
}
