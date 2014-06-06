using System;

class Program
{
    static void Main()
    {
        // input
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        // logic
        int result = 0;
        if (x == 0 && y == 0)
        {
            result = 0;
        }
        else if (x > 0 && y > 0)
        {
            result = 1;
        }
        else if (x < 0 && y > 0)
        {
            result = 2;
        }
        else if (x < 0 && y < 0)
        {
            result = 3;
        }
        else if (x > 0 && y < 0)
        {
            result = 4;
        }
        if (x == 0 && y != 0)
        {
            result = 5;
        }
        if (x != 0 && y == 0)
        {
            result = 6;
        }

        // output
        Console.WriteLine(result);
    }
}
