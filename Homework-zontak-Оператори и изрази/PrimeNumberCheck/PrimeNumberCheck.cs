﻿using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine()); 
        if ((num == 2) || (num == 3) || (num == 5) || (num == 7))
        {
            Console.WriteLine(true); 
            return; 
        } 
        if ((num % 2 == 0) || (num % 3 == 0) || (num % 5 == 0) || (num % 7 == 0) || (num == 0) || (num == 1))
        {
            Console.WriteLine(false);
            return; 
        } 
        else 
        { 
            Console.WriteLine(true); 
            return;
        }

    }
}
