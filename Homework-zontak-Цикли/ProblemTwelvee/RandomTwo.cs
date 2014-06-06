using System;
class ProblemTwelvee
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = i + 1;
        }
        Random rnd = new Random();

        foreach (int i in array)
        {
            int randNum = rnd.Next(0, num);
            int temp = array[randNum];
            array[randNum] = array[0];
            array[0] = temp;
        }
        Console.WriteLine(String.Join(" ", array));
    }
}
