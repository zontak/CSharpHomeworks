using System;
class ZeroSubset
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
        }
        else if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
        }
        else if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
        }
        else if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
        }
        else if (c + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, b);
        }
        else if (d + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, b);
        }
        else if (e + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", e, b);
        }
        else if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
        }
        else if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
        }
        else if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
        }
        else if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
        }
        else if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
        }
        else if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
        }
        else if (a + e + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, e, c);
        }
        else if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
        }
        else if (a + e + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, e, d);
        }
        else if (c + e + b == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, e, b);
        }
        else if (b + e + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, e, d);
        }
        else if (b + e + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, e, c);
        }
        else if (b + e + d + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, e, d, c);
        }
        else if (e + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", e, c, d);
        }
        else if (d + c + b == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", d, c, b);
        }
        else
        {
            Console.WriteLine(" No zero subset ");
        }
    }
}
