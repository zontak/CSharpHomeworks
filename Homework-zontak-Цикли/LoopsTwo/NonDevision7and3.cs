﻿using System;
class NonDevision7and3
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ( i % 3 != 0 && i % 7 !=0 )
            {
                Console.Write(i + " ");
            }
        }
    }
}
