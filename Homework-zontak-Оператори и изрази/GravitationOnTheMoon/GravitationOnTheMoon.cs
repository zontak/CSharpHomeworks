using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine(" KG? : ");
        byte kg = byte.Parse(Console.ReadLine());
        double number = kg * 0.17;
        Console.WriteLine(number);
    }
}
