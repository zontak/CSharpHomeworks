using System;
class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine(" Write number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine(" Odd ");
        }
        else
        {
            Console.WriteLine(" Even ");
        }
    }
}