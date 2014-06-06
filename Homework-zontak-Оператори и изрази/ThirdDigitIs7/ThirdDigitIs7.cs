using System;
class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int numberTwo = n / 100;
        int thirdDigit = numberTwo % 10;
        bool seven = thirdDigit == 7;
        Console.WriteLine(seven);
    }
}

