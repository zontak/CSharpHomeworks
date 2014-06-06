using System;
class RandomNums
{
    static void Main()
    {
        Console.Write(" enter how numbers: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max: ");
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0,2} ", rnd.Next(min, max));
        }
    }
}
