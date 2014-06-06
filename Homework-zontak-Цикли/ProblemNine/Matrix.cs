using System;
class Matrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter number < 20");
        byte n = byte.Parse(Console.ReadLine());
        if ((n <= 20) && (n >= 1))
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 2}", row + col);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine(" Invalid input ");
        }
    }
}