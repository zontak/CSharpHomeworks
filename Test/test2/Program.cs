using System;

class ExchangeBitsFirst
{
    static void Main()
    {
        //   // input 
        //uint input = uint.Parse(Console.ReadLine());

        //// logic
        //uint result = 0;

        ////generate masks
        //uint mask1 = 7 << 3;
        //uint mask2 = 7 << 24;

        //// read bits 3,4,5 and 24, 25, 26

        //uint bits345 = input & mask1;
        //uint bits2456 = input & mask2;

        //// place zeroes in bits positions
        //result &=  ~mask1;
        //result &= ~mask2;

        //bits345 <<= (24 - 3);
        //bits2456 >>= (24 - 3);

        //// place bits in positions
        //result |= bits2456;
        //result |= bits345;

        //Console.WriteLine(result);


        int k = int.Parse(Console.ReadLine());
        int mask = 0;
        for (int i = 0; i < k; i++)
        {
            mask <<= 1;
            mask |= 1;
        }
    }
}