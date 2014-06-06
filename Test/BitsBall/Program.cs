using System;
using System.Collections.Generic;
using System.Linq;


namespace BitBall
{
    class Program
    {
        static void Main()
        {
            int lengthField = 8;
            List<int> firstTeamPlayes = new List<int>();
            List<int> secondTeamPlayes = new List<int>();
            List<int> field = new List<int>();

            int firstTeamResult = 0;
            int secondTeamResult = 0;

            for (int i = 0; i < lengthField; i++)
            {
                firstTeamPlayes.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lengthField; i++)
            {
                secondTeamPlayes.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lengthField; i++)
            {
                field.Add(firstTeamPlayes[i] ^ secondTeamPlayes[i]);
            }

            for (int row = 0; row < lengthField; row++)
            {
                for (int col = 0; col < lengthField; col++)
                {
                    int currentFirsTeamEl = firstTeamPlayes[row];
                    int currentBit = GetBitOnPosition(currentFirsTeamEl, col);
                    int fieldCurrentNumber = field[row];
                    int currentBitFiled = GetBitOnPosition(fieldCurrentNumber, col);
                    bool hasScore = true;
                    if (currentBit == 1 && currentBitFiled == 1)
                    {

                        for (int fieldrow = row + 1; fieldrow < lengthField; fieldrow++)
                        {
                            int nextRowBit = GetBitOnPosition(field[fieldrow], col);
                            if (nextRowBit == 1)
                            {
                                hasScore = false;
                                break;
                            }
                        }

                        if (hasScore)
                        {
                            firstTeamResult++;
                        }
                    }
                }
            }


            for (int row = 0; row < lengthField; row++)
            {
                for (int col = 0; col < lengthField; col++)
                {
                    int currentSecondNumber = secondTeamPlayes[row];
                    int currentBit = GetBitOnPosition(currentSecondNumber, col);
                    int fieldCurrentNumber = field[row];
                    int currentBitFiled = GetBitOnPosition(fieldCurrentNumber, col);

                    bool hasScore = true;
                    if (currentBit == 1 && currentBitFiled == 1)
                    {

                        for (int fieldrow = row - 1; fieldrow >= 0; fieldrow--)
                        {
                            int nextRowBit = GetBitOnPosition(field[fieldrow], col);
                            if (nextRowBit == 1)
                            {
                                hasScore = false;
                                break;
                            }
                        }

                        if (hasScore)
                        {
                            secondTeamResult++;
                        }
                    }
                }
            }

            Console.WriteLine(firstTeamResult + ":" + secondTeamResult);

        }

        static int GetBitOnPosition(int number, int position)
        {
            return (number & (1 << position)) > 0 ? 1 : 0;
        }
    }
}