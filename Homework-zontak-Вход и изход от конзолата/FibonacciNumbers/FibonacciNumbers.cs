using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        string n = Console.ReadLine();
        int number = int.Parse(n);
        BigInteger firstNum = -1;
        BigInteger secondNum = 1;
        for (int i = 0; i < number; i++)
        {
            BigInteger thirdNum = 0;
            thirdNum = firstNum + secondNum;
            Console.Write(thirdNum + " ");
            firstNum = secondNum;
            secondNum = thirdNum;
        }
    }
}
