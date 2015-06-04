using System;
class Palindromes
{
    static void Main()
    {
        string entryText = "Enter your word: ";
        Console.Write(entryText);

        string stringIn = Console.ReadLine();
        int charCount = stringIn.Length;
        char[,] matrix = new char[charCount, charCount];



        for (int i = 0; i < charCount; i++)
        {
            int row = 0;
            for (int coll = i; coll < charCount; coll++, row++)
            {
                matrix[row, coll] = stringIn[i];
            }

        }

        for (int i = charCount - 1; i > 0; i--)
        {
            int row = charCount - 1;
            for (int coll = i - 1; coll >= 0; coll--, row--)
            {
                matrix[row, coll] = stringIn[i];
            }

        }

        int nuberOfCouples = charCount / 2;
        bool thereIsNotPalin = true;

        for (int row = 0; row < charCount; row++)
        {
            bool isPalin = true;
            
            char[] currentComb = new char[charCount];

            for (int coll = 0; coll < charCount; coll++)
            {
                currentComb[coll] = matrix[row, coll];
            }

            int lastIndex = charCount - 1;
            for (int i = 0; i < nuberOfCouples; i++)
            {
                if (currentComb[i] != currentComb[lastIndex])
                {
                    isPalin = false;
                }
                lastIndex--;
            }
            if (isPalin)
            {
                for (int i = 0; i < charCount; i++)
                {
                    Console.Write(currentComb[i]);
                }
                Console.WriteLine();
                thereIsNotPalin = false;
            }
        }
        if (thereIsNotPalin)
	{
		 Console.WriteLine("NONE");
	}
    }
}
