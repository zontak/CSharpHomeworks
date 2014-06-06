using System;
class SumOfNNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int n = int.Parse(numbers);
        int currentNum = 0;
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers = Console.ReadLine();
                currentNum = int.Parse(numbers);
                sum = sum + currentNum;
        }
        Console.WriteLine(sum);
    }
}
