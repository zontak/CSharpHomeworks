using System;
using System.Numerics;

public enum Player
{
    First,
    Second

}

class CardWars
{
    const int NumberOfCardsPerHand = 3;

    //global variables that keep certain relevant information (as obvious by their names)
    static BigInteger firstPlayerScore = 0;
    static BigInteger secondPlayerScore = 0;

    static bool firstPlayerXCardDrawn = false;
    static bool secondPlayerXCardDrawn = false;

    static int firstPlayerGamesWon = 0;
    static int secondPlayerGamesWon = 0;

    static void Main()
    {
        //read how many games will be played
        int numberOfGames = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfGames; i++)
        {
            //variables that hold the score of the current hand of a player
            int currentFirstPlayerScore = 0;
            int currentSecondPlayerScore = 0;

            //for each game each player draws three cards that make up thier hand
            for (int j = 0; j < NumberOfCardsPerHand; j++)
            {
                //the following method draws a signle card (reads a line from the console) and evaluates the consequences of drawing that card
                currentFirstPlayerScore += DrawCardAndCalculatePoints(Player.First);
            }
            for (int j = 0; j < NumberOfCardsPerHand; j++)
            {
                currentSecondPlayerScore += DrawCardAndCalculatePoints(Player.Second);
            }
            //when both player draw the X card in a single game they are both awarded 50 points and the game (and evaluation of the score from the other cards in the hand) continues
            if (firstPlayerXCardDrawn && secondPlayerXCardDrawn)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
                firstPlayerXCardDrawn = false;
                secondPlayerXCardDrawn = false;
            }
            //when only one of the players draws the X card they automatically win the whole match and the game ends.
            else if (firstPlayerXCardDrawn)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (secondPlayerXCardDrawn)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }

            //when all cards are drawn the scores of the hands are compared and only the greater one(if present) is added to the correspoding total score.
            if (currentFirstPlayerScore > currentSecondPlayerScore)
            {
                firstPlayerScore += currentFirstPlayerScore;
                firstPlayerGamesWon++;
            }
            else if (currentFirstPlayerScore < currentSecondPlayerScore)
            {
                secondPlayerScore += currentSecondPlayerScore;
                secondPlayerGamesWon++;
            }

        }
        //comparing the total scores of the players, we find the winner
        if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
            Console.WriteLine("Games won: {0}", firstPlayerGamesWon);
        }
        else if (firstPlayerScore < secondPlayerScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerScore);
            Console.WriteLine("Games won: {0}", secondPlayerGamesWon);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", secondPlayerScore);
        }

    }

    //method that takes as parameter the caller (using an enumeration) and returns the points from a card that is read from the console.
    private static int DrawCardAndCalculatePoints(Player player)
    {
        int points = 0;
        string card = Console.ReadLine();

        switch (card)
        {
            //for the 'ordinary' cards, the method simply returns the score of the card
            case "A": points += 1; break;
            case "J": points += 11; break;
            case "Q": points += 12; break;
            case "K": points += 13; break;
            //for the 'special' cards the method interacts with one of the global variables defined above
            case "X":
                {
                    //from the parameter, the method knows whose score or other states to alter.
                    if (player == Player.First)
                    {
                        firstPlayerXCardDrawn = true;
                    }
                    else // if(player == Player.Second)
                    {
                        secondPlayerXCardDrawn = true;
                    }
                }

                break;
            case "Y":
                {
                    if (player == Player.First)
                    {
                        firstPlayerScore -= 200;
                    }
                    else
                    {
                        secondPlayerScore -= 200;
                    }
                }
                break;

            case "Z":
                {
                    if (player == Player.First)
                    {
                        firstPlayerScore *= 2;
                    }
                    else
                    {
                        secondPlayerScore *= 2;
                    }
                }
                break;
            //due to the imput being always valid and having already covered all other possible cases, the 'default' of the switch statement is reached only when the card is between 2 and 10
            default:
                //when the card is one of the 'numerical cards' (2 - 10) the score for the card can be calculated using the following formula
                points += 12 - int.Parse(card);
                break;
        }
        //return the score of the card drawn (returns zero when the card doesn't alter the current player score)
        return points;
    }
}