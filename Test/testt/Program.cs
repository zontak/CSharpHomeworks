using System;
using System.Linq;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int iterations = number / 2;



        for (int i = 0; i < iterations; i++)
        {
            char[] dots = new string('.', number).ToCharArray();
            dots[i] = '\\';
            dots[iterations] = '|';
            dots[(dots.Length - 1) - i] = '/';
            Console.WriteLine(new string(dots));
        }
        Console.WriteLine(new string('-', iterations) + "*" + new string('-', iterations));
        for (int i = iterations - 1; i >= 0; i--)
        {
            char[] dots = new string('.', number).ToCharArray();
            dots[i] = '/';
            dots[iterations] = '|';
            dots[(dots.Length - 1) - i] = '\\';
            Console.WriteLine(new string(dots));
        }


    }
}
