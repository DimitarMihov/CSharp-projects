using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReversWordsInSentence
{
    /*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!" ->
     * "Delphi not and PHP, not C++ not is C#!".*/

    
    static void Main()
    {
        string text = " C# is not C++, not PHP and not Delphi!";
        string punctuation = @"\s+|,|\.\s*|!\s*|\?\s*";
        string word = @"\b\w+\+\b";

        Regex puncRegex = new Regex(punctuation);
        Regex wordRegex = new Regex(punctuation);

        List<string> arrayPunc = new List<string>();
        List<string> arrayWord = new List<string>();

        foreach (Match item in puncRegex.Matches(text))
        {
            arrayPunc.Add(item.Value);

        }

        foreach (string item in wordRegex.Split(text))
        {
            arrayWord.Add(item);
        }

        arrayWord.Reverse();

        StringBuilder finalText = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (i < arrayWord.Count)
            {
                finalText.Append(arrayWord[i]);
            }

            if (i < arrayPunc.Count)
            {
                finalText.Append(arrayPunc[i]);
            }
        }

        Console.WriteLine(finalText.ToString());
    }
}
