using System;
class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        int[] intArray = new int[charArray.Length];

        for (int i = 0; i < charArray.Length; i++)
        {
            switch (charArray[i])
            {
                case '0': intArray[i] = 0; break;
                case '1': intArray[i] = 1; break;
                case '2': intArray[i] = 2; break;
                case '3': intArray[i] = 3; break;
                case '4': intArray[i] = 4; break;
                case '5': intArray[i] = 5; break;
                case '6': intArray[i] = 6; break;
                case '7': intArray[i] = 7; break;
                case '8': intArray[i] = 8; break;
                case '9': intArray[i] = 9; break;
                case 'A': intArray[i] = 10; break;
                case 'B': intArray[i] = 11; break;
                case 'C': intArray[i] = 12; break;
                case 'D': intArray[i] = 13; break;
                case 'E': intArray[i] = 14; break;
                case 'F': intArray[i] = 15; break;
                default: break;
            }
        }
        double decimalNumber = 0.0d;
        for (int i = 0; i < charArray.Length; i++)
        {
            decimalNumber += (double)intArray[i] * Math.Pow((double)16, (double)i);
        }
        Console.WriteLine(decimalNumber);
    }
}

