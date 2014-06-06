using System;
class Program
{
    static void Main()
    {
        string startStr = "1:30 PM";
        string endStr = "3:00 AM";

        DateTime start = DateTime.Parse(startStr);
        DateTime end = DateTime.Parse(endStr).AddDays(1);

        string input = Console.ReadLine();
        DateTime time = DateTime.Parse(input);
        if (time.Hour < 12)
        {
            time = time.AddDays(1);
        }
        bool isinRange = time >= start && time <= end;
        if (isinRange)
        {
            Console.WriteLine("Beer Time");
        }
        else
        {
            Console.WriteLine("non - beer time");
        }
    }
}