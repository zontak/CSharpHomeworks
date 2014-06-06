using System;
class ExchangeIfGreater
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC;
        if ( numberA > numberB)
        {
            numberC = numberA;
            numberA = numberB;
            numberB = numberC;
            Console.WriteLine("{0} {1}", numberA, numberB);
        }
        else
        {
            Console.WriteLine("{0} {1}", numberA, numberB);
        }
    }
}
