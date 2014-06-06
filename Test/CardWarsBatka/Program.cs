using System;

public enum Players
{
    First ,
    Second
}
class Program
{
    const int numberOfCardsPerHand = 3;

    static long firstPlayerScore = 0;
    static long secondPlayerScore = 0;
    static bool firstPlayerXCardDraw = false;
    static bool secondPlayerXCardDraw = false;
    static int firstPlayerGamesWon = 0;
    static int secondPlayerGamesWon = 0;
    static void Main()
    {
        int numberOfGames = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfGames; i++)
        {
            int currentFirstPlayerScore = 0;
            int currentSecondPlayerScore = 0;

            for (int j = 0; j < numberOfCardsPerHand; j++)
            {
                currentFirstPlayerScore += DrawCardAndCalculatePoints(Players.First);
            }
            for (int j = 0; j < numberOfCardsPerHand; j++)
            {
                currentSecondPlayerScore += DrawCardAndCalculatePoints(Players.Second);
            }
            if (firstPlayerXCardDraw && secondPlayerXCardDraw)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
                firstPlayerXCardDraw = false;
                secondPlayerXCardDraw = false;
            }
            else if (firstPlayerXCardDraw )
            {
                Console.WriteLine("X card  drawn! Player one wins the match! ");
                return;
            }
            else if (secondPlayerXCardDraw)
            {
                Console.WriteLine("X card  drawn! Player two wins the match! ");
                return;
            }
            if (currentFirstPlayerScore > currentSecondPlayerScore)
            {
                firstPlayerScore += currentFirstPlayerScore;
                firstPlayerGamesWon++;
            }
            else if ( currentFirstPlayerScore < currentSecondPlayerScore)
            {
                secondPlayerScore += currentSecondPlayerScore;
                secondPlayerGamesWon++;
            }
            
        }
        if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First plaer winds!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
            Console.WriteLine("Games win: {0}", firstPlayerGamesWon);
        }
        else if (firstPlayerScore < secondPlayerScore)
        {
            Console.WriteLine("First plaer winds!");
            Console.WriteLine("Score: {0}", secondPlayerScore);
            Console.WriteLine("Games win: {0}", secondPlayerGamesWon);
        }
        else
        {
            Console.WriteLine("It`s a tie!");
            Console.WriteLine("Score: {0}" ,secondPlayerScore);
        }
    }

    private static int DrawCardAndCalculatePoints(Players player)
    {
        int points = 0;
        string card = Console.ReadLine();

        switch (card)
        {
            case "A": points += 1; break;
            case "J": points += 11; break;
            case "Q": points += 12; break;
            case "K": points += 13; break;
            case "X": 
                {
                    if (player == Players.First)
                    {
                        firstPlayerXCardDraw = true;
                    }
                    else
                    {
                        secondPlayerXCardDraw = true;
                    }
                } break;
            case "Y":
                {
                    if (player == Players.First)
                    {
                        firstPlayerScore -= 200;
                    }
                    else
                    {
                        secondPlayerScore -= 200;
                    }
                } break;
            case "Z":
                {
                    if (player == Players.First)
                    {
                        firstPlayerScore *= 2;
                    }
                    else
                    {
                        secondPlayerScore *= 2;
                    }
                } break;
            default: points += 12 - int.Parse(card); break;
        }

        return points;

    }
}

