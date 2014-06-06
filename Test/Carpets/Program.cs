using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string backslash = "/";
        string backslashS = "\\";
        char dots = '.';
        string space = " ";
        string slashss = "/\\";
        string slashssDown = "\\/";
        int dotsRow = ((number / 2));
        int up = 1;
        Console.WriteLine(new string(dots, dotsRow) + new string('/', 1) + new string('\\',1) + new string(dots,dotsRow));
        for (int i = 1; i < number / 2; i++)
        {
            dotsRow--;
            Console.Write(new string(dots, dotsRow));
            Console.Write(backslash + space);
            up = (i / 2) - 1;
            for (int k = 0; k < up; k++)
            {
                if (i % 2 == 0 && i > 2)
                {
                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', 1));
                }
            }
            if (i % 2 == 0)
            {
                Console.Write(slashss);
            }
            for (int j = 0; j < up; j++)
			   {
                    if (i % 2 == 0 && i > 2)
                    {
                        Console.Write(new string(' ', 1));
                        Console.Write(new string('\\', 1));
                    }
               }
            for (int m = 0; m <= up; m++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', 1));
                }
            }
            for (int l = 0; l <= up; l++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    Console.Write(new string(' ', 1));
                    Console.Write(new string('\\', 1));
                }
            }
            Console.Write(space + backslashS);
            Console.WriteLine(new string(dots, dotsRow));
        }

        // down

        for (int i = number / 2 - 1 ; i > 0; i--)
        {
            Console.Write(new string(dots, dotsRow));
            Console.Write(backslashS + space);
            up = (i / 2) - 1;
            for (int k = 0; k < up; k++)
            {
                if (i % 2 == 0 && i > 2)
                {
                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', 1));
                }
            }
            if (i % 2 == 0)
            {
                Console.Write(slashssDown);
            }
            for (int j = 0; j < up; j++)
            {
                if (i % 2 == 0 && i > 2)
                {
                    Console.Write(new string(' ', 1));
                    Console.Write(new string('/', 1));
                }
            }
            for (int m = 0; m <= up; m++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', 1));
                }
            }
            for (int l = 0; l <= up; l++)
            {
                if (i % 2 != 0 && i > 1)
                {
                    Console.Write(new string(' ', 1));
                    Console.Write(new string('/', 1));
                }
            }
            Console.Write(space + backslash);
            Console.WriteLine(new string(dots, dotsRow));
            dotsRow++;
        }
        Console.WriteLine(new string('.', (number / 2)) + new string('\\', 1) + new string('/', 1) + new string('.', (number / 2)));
    }
}
