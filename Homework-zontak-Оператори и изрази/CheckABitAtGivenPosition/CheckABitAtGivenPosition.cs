using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n=");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter index p");
        int indexP = int.Parse(Console.ReadLine());
        Console.Write("n binary:");
        Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
        int moveNumberN = numberN >> indexP;
        int bit = moveNumberN & 1;
        Console.Write("The value of the given bit at index p is --> ");
        Console.WriteLine(Convert.ToString(bit, 2));
    }
}
