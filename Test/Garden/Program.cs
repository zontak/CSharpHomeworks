using System;
class Program
{
    static void Main()
    {

        decimal tomato = 0.5m;
        decimal cucumber = 0.4m;
        decimal patato = 0.25m;
        decimal carrot = 0.6m;
        decimal cabbage = 0.3m;
        decimal beans = 0.4m;
        decimal totalArea = 250;

        decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());
        decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());
        decimal patatoSeeds = decimal.Parse(Console.ReadLine());
        decimal patatoArea = decimal.Parse(Console.ReadLine());
        decimal carrotSeeds = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());
        decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());
        decimal beansSeeds = decimal.Parse(Console.ReadLine());

        decimal totalPrice = tomatoSeeds * tomato + cucumberSeeds * cucumber + patatoSeeds * patato + carrot * carrotSeeds + cabbage * cabbageSeeds + beans * beansSeeds;

        Console.WriteLine("Total coasts: {0:F2}", totalPrice);

        decimal beansArea = totalArea - tomatoArea - cucumberArea - patatoArea - carrotArea - cabbageArea;

        if (beansArea > 0)
        {
            Console.WriteLine("beans area: {0} ", beansArea);
        }
        else if ( beansArea == 0)
        {
            Console.WriteLine(" No area for beans ");
        }
        else
        {
            Console.WriteLine(" Insufficient area ");
        }
    }
}

