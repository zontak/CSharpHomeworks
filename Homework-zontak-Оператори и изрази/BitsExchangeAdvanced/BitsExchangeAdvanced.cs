using System;
class BitsExchangeAdvanced
{
    static void Main()
    {

        Console.WriteLine("n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("k");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("p");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("q");
        int q = int.Parse(Console.ReadLine());

        int flagsStart = 0;
        for (int i = p; i < p + k; i++)
        {
            flagsStart |= 1 << i;
        }
        int flagsEnd = 0;
        for (int i = q; i < q + k; i++)
        {
            flagsEnd |= 1 << i;
        }

        // take bits
        int bitsStart = n & flagsStart;
        int bitsEnd = n & flagsEnd;

        // shift bits to desired place
        bitsStart <<= p - k;
        bitsEnd >>= q - k;

        //empty bits at positions
        n = ~flagsStart & n;
        n = ~flagsEnd & n;
        //place bits
        n |= bitsStart;
        n |= bitsEnd;
        Console.WriteLine(n);

    }
}