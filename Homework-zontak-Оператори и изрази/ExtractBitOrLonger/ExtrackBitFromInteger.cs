using System;
class Program
{
    static void Main()
    {
        Console.Write(" enter n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write(" Enter p: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int integerche = mask & number;
        bool boolche = integerche > 0;
        Console.WriteLine(boolche);
    }
}
