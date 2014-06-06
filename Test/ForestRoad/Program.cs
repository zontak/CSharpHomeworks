using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 1) + new string('.', number - 1));
            int dotsFirst = 1;
            int dotsSecond = number - 1;
            int stars = 1;
            for (int i = 1; i < number; i++)
            {
                dotsSecond -= 1;
                Console.Write(new string('.', dotsFirst));
                Console.Write(new string('*', stars));
                Console.Write(new string('.', dotsSecond));
                Console.WriteLine();
                dotsFirst +=1;
            }
            --dotsFirst;
            ++dotsSecond;
            for (int i = 0; i < number - 1; i++)
            {
                --dotsFirst;
                Console.Write(new string('.', dotsFirst));
                Console.Write(new string('*', stars));
                Console.Write(new string('.', dotsSecond));
                Console.WriteLine();
                dotsSecond++;
            }
        }
    }
}
