using System;
class Program
{
    static void Main()
    {
        int numberInDec = 0;
        int number = int.Parse(Console.ReadLine());
        int position = 0;
        while (number > 0 )
        {
            int lastnumber = number % 10;
            numberInDec += lastnumber * (int)Math.Pow(7, position);
            position++;
            number = number / 10;
        }
        Console.WriteLine(numberInDec);
    }
}

