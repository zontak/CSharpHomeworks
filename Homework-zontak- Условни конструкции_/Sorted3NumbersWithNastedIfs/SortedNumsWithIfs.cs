﻿using System;
class SortedNumsWithIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ( a > b )
        {
            if ( b > c )
            {
                Console.WriteLine("{0} {1} {2}", a , b , c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a , c , b);
            }
        }
        else if ( b > c)
        {
            if ( c > a)
            {
                Console.WriteLine("{0} {1} {2}", b , c , a);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b , a , c);
            }
        }
        else if ( c > a)
        {
            if (b > a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c ,a , b);
            }
        }
    }
}

