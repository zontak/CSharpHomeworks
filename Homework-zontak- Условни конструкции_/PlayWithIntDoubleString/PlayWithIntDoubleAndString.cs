using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine(" Please Choise A Type: \n 1 --> int \n 2 --> double \n 3 --> string ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.Write(" Enter integer value: ");
                int intNumber = int.Parse( Console.ReadLine());
                int intSum = intNumber + 1;
                Console.WriteLine(intSum);
                break;
            case 2:
                Console.Write(" Enter double value: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                double doubleSum = doubleNumber + 1;
                Console.WriteLine(doubleSum);
                break;
            case 3:
                Console.Write(" Enter string: ");
                string stringche = Console.ReadLine();
                Console.WriteLine(stringche + "*");
                break;
            default: Console.WriteLine(" Invalid input.. ");
                break;
        }
    }
}

