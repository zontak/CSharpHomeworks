using System;

namespace ConsoleApplication1
{
    class longSequence
    {
        static void Main()
        {
            for (int i = 0; i < 1000; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.WriteLine("{0,2}", i+2);
                }
                else
                {
                    Console.WriteLine("{0,2}", -(i+2));
                }
            }
        }
    }
}
