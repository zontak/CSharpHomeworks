using System;
class binaryToDecimal
{
    static void Main()
    {
        string numberbinary = Console.ReadLine();
        char[] array = numberbinary.ToCharArray();
        Array.Reverse(array);

        long decimalche = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == '1')
            {
                decimalche += (long)Math.Pow((long)2, (long)i);
            }
        }
        Console.WriteLine(decimalche);
    }
}

