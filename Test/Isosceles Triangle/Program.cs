using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isosceles_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char copyRight = '\u00A9';
            // Console.WriteLine(copyRight);

            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = (rows * 2) - 1; // this is the unique formula for all measures

            int[,] matrix = new int[rows, cols];

            int currentRow = 0;
            int currentCol = cols / 2;

            for (int i = 0; i < rows; i++)
            {
                if (i + 1 == rows)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j % 2 == 0)
                        {
                            matrix[currentRow, j] = 1;
                        }
                    }
                }

                matrix[currentRow, currentCol - i] = 1;
                matrix[currentRow, currentCol + i] = 1;
                currentRow++;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        Console.Write(copyRight);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
