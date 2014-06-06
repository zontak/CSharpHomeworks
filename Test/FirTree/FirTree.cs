using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class FirTree
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            byte number = byte.Parse(Console.ReadLine());
            int star = 1;
            int space = number - 2;

            for (int i = 1; i < number; i++)
            {
                Console.Write(new string('.', space));
                Console.Write(new string('*', star));
                Console.Write(new string('.', space));
                Console.WriteLine();
                star += 2;
                space--;
            }
            int stem = number - 2;
            Console.WriteLine(new string('.', stem) + new string('|', 1) + new string('.', stem));
        }
    }
}
