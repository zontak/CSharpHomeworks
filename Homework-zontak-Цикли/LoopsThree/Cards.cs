using System;

class Cards
{
    static void Main()
    {

        char clubs = (char)9827;
        char diams = (char)9830;
        char hearts = (char)9829;
        char spades = (char)9824;

        for (int i = 2; i < 15; i++)
        {
            if (i < 11)
            {
                Console.WriteLine(i.ToString() + (clubs) + " " + i.ToString() + diams + " " + i.ToString() + hearts + " " + i.ToString() + spades);
            }
            else
            {
                switch (i)
                {
                    case 11: Console.WriteLine("J" + clubs + " " + "J" + diams + " " + "J" + hearts + " " + "J" + spades); break;
                    case 12: Console.WriteLine("D" + clubs + " " + "D" + diams + " " + "D" + hearts + " " + "D" + spades); break;
                    case 13: Console.WriteLine("K" + clubs + " " + "K" + diams + " " + "K" + hearts + " " + "K" + spades); break;
                    case 14: Console.WriteLine("A" + clubs + " " + "A" + diams + " " + "A" + hearts + " " + "A" + spades); break;
                }
            }
        }
         
    }
}

