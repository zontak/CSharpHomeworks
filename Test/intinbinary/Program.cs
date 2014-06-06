using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intinbinary
{
    class Program
    {
        public static String GetBits(int input)
        {
            char[] bits = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((input & (1 << i)) != 0)
                {
                    bits[pos] = '1';
                }
                else
                {
                    bits[pos] = '0';
                }
                pos--;
                i++;
            }
            return new String(bits);
        }
    }
}
