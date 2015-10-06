using System;

class ExtractPalindromes
{
    static void Main()
    {
        /*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/
        
        string text = @"I like ABBA . When I listen to ABBA I say oho.";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] split = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach (string word in split)
        {
            bool isPal = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPal = false;
                    break;
                }
            }
            if (isPal && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
