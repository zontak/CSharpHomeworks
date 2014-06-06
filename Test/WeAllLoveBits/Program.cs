using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] Pnew = new int[n];
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                while (true)
                {
                    Pnew[i] <<= 1;
                    int firstbit = p & 1;
                    Pnew[i] |= firstbit;
                    p >>= 1;
                }
            }
            foreach (int mm in Pnew)
            {
                Console.WriteLine(mm);
            }
        }
    }
}
