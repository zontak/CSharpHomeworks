using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anacii2
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            int numberLines = int.Parse(Console.ReadLine());
            int firstNumberIndex = 0;
            int secondNumberIndex = 0;
            int thirdNumber = 0;

            char[] alpha = "1ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < alpha.Length; i++)
            {
                if (firstLetter == alpha[i])
                {
                    firstNumberIndex = i;
                }
            }


        }


    }
}