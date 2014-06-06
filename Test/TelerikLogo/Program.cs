using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikLogo
{
    class Program
    {

        static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            int z = (x / 2) + 1;
            int length = (2 * z) + (2 * x) - 3;
            int innerDots = length - (2 * z);
            int outerDots = x / 2;

            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDots), new string('.', innerDots));

            int middleDots = 1;
            for (int i = 0; i < z - 1; i++)
            {
                outerDots--;
                innerDots -= 2;

                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                    new string('.', outerDots), new string('.', middleDots),
                    new string('.', innerDots));

                middleDots += 2;
            }

            if (x != 3)
            {
                innerDots -= 2;
                while (innerDots > 0)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', middleDots), new string('.', innerDots));

                    innerDots -= 2;
                    middleDots++;
                }
            }

            string centerDotQuadrant = string.Format("{0}*{0}", new string('.', length / 2));
            Console.WriteLine(centerDotQuadrant);

            int innerSquareDots = 1;
            int outerSquareDots = length / 2 - 1;
            for (int i = 0; i < x - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerSquareDots),
                    new string('.', innerSquareDots));

                innerSquareDots += 2;
                outerSquareDots--;
            }

            outerSquareDots += 2;
            innerSquareDots -= 4;
            for (int i = 0; i < x - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerSquareDots),
                    new string('.', innerSquareDots));

                innerSquareDots -= 2;
                outerSquareDots++;
            }

            Console.WriteLine(centerDotQuadrant);
        }
    }
}