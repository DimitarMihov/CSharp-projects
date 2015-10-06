using System;

class RegionsToUppercase
{
    /*Write a program that extracts from a given text all sentences containing given word.
     * Consider that the sentences are separated by "." and the words – by non-letter symbols. */

    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string newText = "";
        int indexEnd = 0;
        string word = " in ";
        string endSentence = ".";
        int regionStart = 0;

        while (indexEnd >= 0)
        {
                indexEnd = SearchIndex(text, endSentence, regionStart);
                if (indexEnd > -1)
                {
                    newText = text.Substring(regionStart, indexEnd - regionStart) + ".";
                    newText = newText.Trim();
                    if (newText.IndexOf(word) > -1)
                    {
                        Console.WriteLine(newText); 
                    }
                }

                regionStart = indexEnd + endSentence.Length;
        }
    }

    private static int SearchIndex(string wholeString, string subString, int index)
    {
        int newIndex = wholeString.IndexOf(subString, index);
        int theIndex = -1;
        if (newIndex >= 0)
        {
            theIndex = newIndex;
        }

        return theIndex;
    }
}