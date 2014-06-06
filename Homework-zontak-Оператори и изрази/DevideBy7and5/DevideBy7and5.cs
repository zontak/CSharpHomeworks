using System;
class DevideBy7and5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool numIsNotZero = n != 0;
        bool sum = n % 35 == 0 ;
        Console.WriteLine(numIsNotZero && sum);
    }
}

