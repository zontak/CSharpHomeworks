using System;
using System.Linq;
class SpiralMatrix
{
    static void Main()
    {
        int n = 4;
        int[,] matrix = new int[n, n];
        int col = 0;
        int row = 0;
        string direction = "right";
        int maxRotation = n * n;
        for (int i = 1; i <= maxRotation; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0 ))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0 ))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        // painting matrix
        for (int rowche = 0; rowche < n; rowche++)
        {
            for (int colche = 0; colche < n; colche++)
            {
                Console.Write("{0,4}", matrix[rowche,colche]);
            }
            Console.WriteLine();
        }
    }
}

