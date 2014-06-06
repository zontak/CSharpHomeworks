using System;
class NumbersInInterval
{
    static void Main()
    {
        string n = Console.ReadLine();
        int a = int.Parse(n);
        n = Console.ReadLine();
        int b = int.Parse(n);
        for (int i = a; i < b; i++)
        {
            if ( i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
