using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        char slash = '/';
        char backslash = '\\';
        char dot = '.';
        char dash = '-';
        int dashRowIndex = 1;
        int dashRowIncrement = 1;

        for (int i = 0; i < num; i++)
        {
            Console.Write(new string(dot, num - i - 1));
            Console.Write(slash);
            if (i == dashRowIndex)
            {
                Console.Write(new string(dash, i * 2));
                dashRowIncrement++;
                dashRowIndex += dashRowIncrement;
            }
            else
            {
                Console.Write(new string(dot, i * 2));
            }
            Console.Write(backslash);
            Console.WriteLine(new string(dot, num - i - 1));
        }
    }
}

