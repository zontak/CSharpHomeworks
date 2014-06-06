using System;

namespace PrintASequence
{
    class squence
    {
        static void Main()
        {
            for (int i = 0; i < 9; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.WriteLine("{0,4}", i + 2);
                }
                else
                {
                    Console.WriteLine("{0,4}", -(i + 2));
                }
            }
            Console.WriteLine();
        }
    }
}
