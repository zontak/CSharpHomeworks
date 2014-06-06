using System;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', number) + new string('*', 1) + new string('.', number));
        Console.WriteLine(new string('.', number-1) + new string('*',3) + new string('.', number-1));
        int spaceInsideUp = 0;
        int star = 1;
        int numberTwo = number;
        int spaceUp = numberTwo - 1;
        for (int i = 1; i < number - 1; i++)
        {
            star = 1;
            spaceInsideUp += 1;
            numberTwo -= 1;
            spaceUp -= 1;
            Console.Write(new string('.', spaceUp));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceInsideUp));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceInsideUp));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceUp));
            Console.WriteLine();
        }
        Console.WriteLine(new string('*',  ((number * 2) + 1)));
        int spaceDown = 1;
        int spaceInsideDown = spaceInsideUp;
        int theBase = (number + 2) / 3;

        for (int i = 0; i < theBase; i++)
        {
            Console.Write(new string('.', spaceDown));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceInsideDown));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceInsideDown));
            Console.Write(new string('*', star));
            Console.Write(new string('.', spaceDown));
            Console.WriteLine();
            spaceInsideDown--;
            spaceDown++;
        }
        Console.WriteLine(new string('.', spaceDown) + new string('*', number) + new string('.', spaceDown));

    }
}

