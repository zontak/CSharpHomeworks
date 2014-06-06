using System;

class stringAndObject
{
    static void Main()
    {
        string nameOne = "Hello ";
        string nameTwo = "World";
        object sum = nameOne + "," + nameTwo + " !";
        string stringgg = (string)sum;
        Console.WriteLine(stringgg);
    }
}

