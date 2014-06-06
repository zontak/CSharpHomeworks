using System;

namespace DateAfterTenYears
{
    class DateAfter10Years
    {
        static void Main()
        {
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Now: {0}     After ten years: {1}", Age ,(Age + 10));
        }
    }
}
