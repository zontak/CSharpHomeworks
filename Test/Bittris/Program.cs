using System;
class Bittris
{
    static void Main()
    {
        int leftmostBitMask = 128;
        int rightmostBitMask = 1;
        int totalScore = 0;
        int fullRowMask = 255;
        int[] numbers = new int[4];

        int numberOfCommands = int.Parse(Console.ReadLine());

        //Read and process input in sets of 4 rows (1 number and 3 commands for the number)
        for (int i = 0; i < numberOfCommands / 4; i++)
        {
            //read the number that is to be processed later and initialize supporting variables
            int currentNumber = int.Parse(Console.ReadLine());
            int currentRow = 0;
            int currentScore = 0;

            //calculate the score of the number(add a point for each '1' in the bitwise representation of the number)
            for (int j = 0; j < 32; j++)
            {
                if ((currentNumber & (1 << j)) != 0)
                {
                    currentScore++;
                }
            }

            //read the three commands for the number already read above
            string commands = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();


            //execute the commands
            for (int j = 0; j < commands.Length; j++)
            {
                //shift left if possible (possible when the leftmost bit isn't '1')
                if (commands[j] == 'L')
                {
                    if ((currentNumber & leftmostBitMask) == 0)
                    {
                        currentNumber <<= 1;
                    }
                }
                //shift right if possible (possible when the rightmost bit isn't '1')
                else if (commands[j] == 'R')
                {
                    if ((currentNumber & rightmostBitMask) == 0)
                    {
                        currentNumber >>= 1;
                    }
                }

                //fall down attempt after each command (where 'D' command is executed as well)
                if (currentRow != 3 && (currentNumber & numbers[currentRow + 1]) == 0)
                {
                    currentRow++;
                }
                //if fall down is not possible, executing commands stops and the score is evaluated
                else
                {
                    break;
                }
            }

            //save the number on the last possible row
            numbers[currentRow] |= currentNumber;

            //check if the entire row is filled and add coresponding score
            if ((numbers[currentRow] & fullRowMask) == fullRowMask)
            {
                totalScore += 10 * currentScore;

                //shift down all upper rows once the filled row is cleared
                for (int j = currentRow; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = 0;
            }
            else
            {
                totalScore += currentScore;
            }

        }
        //print final result
        Console.WriteLine(totalScore);
    }
}