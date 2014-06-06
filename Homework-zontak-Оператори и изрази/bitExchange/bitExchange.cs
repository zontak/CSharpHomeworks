using System;
class BitExchange
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int mask1 = 7 << 3;
        int mask2 = 7 << 24;
        // take bits
        int bits345 = num & mask1;
        int bits2456 = num & mask2;
        //swap bits
        bits345 <<= 21;
        bits2456 >>= 21;
        //empty bits at positions
        num = ~mask1 & num;
        num = ~mask2 & num;
        //place bits
        num |= bits345;
        num |= bits2456;
        Console.WriteLine(num);
    }
}
