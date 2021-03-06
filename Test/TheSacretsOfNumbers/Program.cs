﻿using System;
class Program
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();
        inputNumber = inputNumber.TrimStart('-');
        var inputCharArray = inputNumber.ToCharArray();
        Array.Reverse(inputCharArray);
        long specialSum = 0;

        for (int i = 0; i < inputCharArray.Length; i++)
        {
            int currentDigit = int.Parse(inputCharArray[i].ToString());
            if ( i % 2 == 1)
            {
                specialSum += currentDigit * currentDigit * (i + 1);
            }
            else
            {
                specialSum += currentDigit * (i + 1) * (i + 1);
            }
        }
        Console.WriteLine(specialSum);

        int sequenceLength = (int)specialSum % 10;
        int currentLetter = (int)(specialSum % 26) + 1;
        
        if ( sequenceLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence ", inputNumber);
        }
        else
        {
            for (int i = 0; i < sequenceLength; i++)
            {
                if (currentLetter + i == 26)
                {
                    currentLetter = 0;
                }
                Console.WriteLine((char)((currentLetter + i) % 26 + 64));
            }
        }
    }
}

