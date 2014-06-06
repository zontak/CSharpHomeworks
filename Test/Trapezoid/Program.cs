using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int dotsOutSide = number - 1;
        int stars = 1;
        int dotsInSide = number - 1;
        Console.WriteLine(new string('.', number) + new string('*', number));
        for (int i = 0; i < number - 1; i++)
        {
            Console.Write(new string('.', dotsOutSide));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', dotsInSide));
            Console.Write(new string('*', stars));
            Console.WriteLine();
            dotsOutSide--;
            dotsInSide++;
        }
        Console.WriteLine(new string('*', number * 2));


    }
}

