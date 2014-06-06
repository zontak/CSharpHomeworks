using System;
class SumOfFiveNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] nums = numbers.Split(new char[] { ' ' });
        int sum = 0;
        foreach (string numStr in nums)
        {
            int num = int.Parse(numStr);
            sum += num;
        }

        Console.WriteLine(sum);
    }
}
