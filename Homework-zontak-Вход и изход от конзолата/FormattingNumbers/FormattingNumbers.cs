using System;
class FormattingNumbers
{
    static void Main()
    {
    Start:
        Console.Write(" A: ");
        int firstNumberA = int.Parse(Console.ReadLine());
        if (firstNumberA > 500 || firstNumberA < 0)
        {
            Console.WriteLine(" Invalid input.. Try again ");
            goto Start;
        }
        Console.Write(" B: ");
        float secondNumberB = float.Parse(Console.ReadLine());
        Console.Write(" C: ");
        float thirdNumberC = float.Parse(Console.ReadLine());
        object convertAtoHex = Convert.ToString(firstNumberA, 16);
        object convertAtoBinary = Convert.ToString(firstNumberA, 2).PadLeft(10, '0');
        Console.WriteLine("|{0,-15}|{1:10}|{2,10:F2}|{3,-10:F3}|", convertAtoHex, convertAtoBinary, secondNumberB, thirdNumberC);
    }
}
