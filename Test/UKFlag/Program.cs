﻿using System;
class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char slash = '/';
        char backslash = '\\';
        char verticalDash = '|';
        char dots = '.';
        char star = '*';
        char dash = '-';
        int dotss = number / 3;
        int outdots = 1;

        //up 

        for (int i = 0; i < number / 2; i++)
        {
            if (i != 0) Console.Write(new string(dots, outdots));
            Console.Write(new string(backslash, 1));
            Console.Write(new string(dots, dotss));
            Console.Write(new string(verticalDash, 1));
            Console.Write(new string(dots, dotss));
            Console.Write(new string(slash, 1));
            if (i != 0)
            {
                Console.Write(new string(dots, outdots));
                outdots+=1;
            }
            dotss -= 1;
            Console.WriteLine();
        }

        //center

        Console.WriteLine(new string(dash, number / 2) + new string(star, 1) + new string(dash, number / 2));
   
        //down

        for (int i = number / 2; i > 0; i--)
        {
            Console.Write(new string(dots, outdots));
            Console.Write(new string(slash, 1));
            if (i < i - 1)
            {
                Console.Write(new string(dots, dotss));
                dotss++;
            }
            Console.Write(new string(verticalDash, 1));
            if (i < i - 1)
            {
                Console.Write(new string(dots, dotss));
                dotss++;
            }
            Console.Write(new string(backslash, 1));
            Console.Write(new string(dots, outdots));
            outdots--;
            Console.WriteLine();
        }
    }
}

