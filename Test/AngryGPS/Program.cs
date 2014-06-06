using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '1': oddSum += 1;
                        break;
                    case '2': evenSum += 2;
                        break;
                    case '3': oddSum += 3;
                        break;
                    case '4': evenSum += 4;
                        break;
                    case '5': oddSum += 5;
                        break;
                    case '6': evenSum += 6;
                        break;
                    case '7': oddSum += 7;
                        break;
                    case '8': evenSum += 8;
                        break;
                    case '9': oddSum += 9;
                        break;
                    default:
                        break;
                }
            }

            if (oddSum > evenSum)
            {
                Console.WriteLine("left {0}", oddSum);
            }
            else if (evenSum > oddSum)
            {
                Console.WriteLine("right {0}", evenSum);

            }
            else
            {
                Console.WriteLine("straight {0}", evenSum);
            }

        }
    }
}
