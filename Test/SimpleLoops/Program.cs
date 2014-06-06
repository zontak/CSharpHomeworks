using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoops
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int x = -1;
            int y = 1;
            int mm ;
            for (int i = 1; i < number; i++)
            {
                mm = x + y;
                Console.WriteLine(mm);
                x = y + mm;
                Console.WriteLine(x);
                y = mm + x;
                Console.WriteLine(y);

            }
        }
    }
}
