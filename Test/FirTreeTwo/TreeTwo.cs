using System;
class TreeTwo
{
    static void Main()
    {
        Console.Write(" Enter number: ");
        byte number = byte.Parse(Console.ReadLine());
        int star = 1;
        int space = number;
        Console.WriteLine(new string('.', space + 1) + new string('*', 1) + new string('.', space + 1));
        for (int i = 1; i < number; i++)
        {
            Console.Write(new string('.', space));
            Console.Write(new string('*', star));
            star += 1;
            space--;
            for (int k = 1; k < 255; k++)
            {
                Console.Write("|");
                break;
            }
            int starTwo = star - 1;
            Console.Write(new string('*', starTwo));
            Console.Write(new string('.', space + 1));
            Console.WriteLine();
            starTwo += 1;
        }
        int stem = number;
        Console.WriteLine(new string('.', stem +1 ) + new string('|', 1) + new string('.', stem + 1));
    }
}

