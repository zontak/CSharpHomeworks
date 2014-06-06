

using System;

class Smetalnik
{

    static void MoveLeft(uint[] nums, int width, int position, int line)
    {
        //adjust the position
        if (position >= width)
        {
            position = 0;
        }
        else if (position < 0)
        {
            position = width - 1;
        }
        else
        {
            position = width - 1 - position;
        }

        int bitsCounter = 0;
        for (int bitPosition = position; bitPosition < width; bitPosition++)
        {
            //count bits
            if ((nums[line] & (1 << bitPosition)) != 0)
            {
                bitsCounter++;

                //reset bits 1 to 0
                uint mask = ~((uint)1 << bitPosition);
                nums[line] &= mask;
            }
        }

        //set new bits to 1 to the left
        //int leftMostPosition = width - 1;
        for (int i = 0; i < bitsCounter; i++)
        {
            nums[line] |= (uint)(1 << width - 1 - i);
        }
    }

    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        uint[] nums = new uint[8];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = uint.Parse(Console.ReadLine());
        }


        while (true)
        {
            string cmd = Console.ReadLine();
            if (cmd == "stop")
            {
                ulong emptyCols = (ulong)CountEmptyCols(nums, width);
                ulong sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                ulong result = sum * emptyCols;
                Console.WriteLine(result);
                return;
            }
            else if (cmd == "left")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());
                MoveLeft(nums, width, position, line);
            }
            else if (cmd == "right")
            {
                int line = int.Parse(Console.ReadLine());
                int position = int.Parse(Console.ReadLine());
                MoveRight(nums, width, line, position);
            }
            else if (cmd == "reset")
            {
                for (int line = 0; line < 8; line++)
                {
                    MoveLeft(nums, width, width - 1, line);
                }
            }
        }
    }

    private static int CountEmptyCols(uint[] nums, int width)
    {
        int emptyCounter = 0;
        for (int col = 0; col < width; col++)
        {
            bool isEmpty = true;
            for (int line = 0; line < 8; line++)
            {
                if ((nums[line] & (uint)(1 << col)) != 0)
                {
                    isEmpty = false;
                    break;
                }
            }
            if (isEmpty)
            {
                emptyCounter++;
            }
        }
        return emptyCounter;
    }

    private static void MoveRight(uint[] nums, int width, int line, int position)
    {
        //adjust the position
        if (position >= width)
        {
            position = 0;
        }
        else if (position < 0)
        {
            position = width - 1;
        }
        else
        {
            position = width - 1 - position;
        }

        int bitsCounter = 0;
        for (int bitPosition = position; bitPosition >= 0; bitPosition--)
        {
            //count 1 bits and reset them to 0
            if ((nums[line] & (1 << bitPosition)) != 0)
            {
                bitsCounter++;
                uint mask = ~((uint)1 << bitPosition);
                nums[line] &= mask;
            }
        }
        //set bits to 1
        //nums[line] |= CalcPow(2, bitsCounter) - 1;

        for (int i = 0; i < bitsCounter; i++)
        {
            nums[line] |= (uint)1 << i;
        }
    }
}

