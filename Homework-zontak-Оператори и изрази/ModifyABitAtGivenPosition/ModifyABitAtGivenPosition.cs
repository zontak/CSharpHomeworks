using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write( " enter the number: " );
        int n = int.Parse(Console.ReadLine());
        Console.Write( " enter the position: " );
        int p = int.Parse(Console.ReadLine());
        Console.Write( " enter value: " );
        int v = int.Parse(Console.ReadLine());
        int mask = v << p;
        n = n & (~(1 << p));
        int result = n | mask;
        Console.WriteLine(result);
    }
}
