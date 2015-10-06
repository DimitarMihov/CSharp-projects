using System;

class RegionsToUppercase
{
    /*You are given a text. Write a program that changes the
     * text in all regions surrounded by the tags <upcase>
     * and </upcase> to uppercase. The tags cannot be nested. */
    
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string newText = "";
        int indexStart = 0;
        int indexEnd = 0;
        string startString = "<upcase>";
        string endString = "</upcase>";
        int regionStart = 0;
        int regionEnd = 0;

        while (indexStart >= 0)
        {
            indexStart = SearchIndex(text, startString, indexStart);
            if (indexStart > -1)
            {
                regionStart = indexStart + startString.Length;
                indexEnd = SearchIndex(text, endString, regionStart);
                if (indexEnd > -1)
                {
                    regionEnd = indexEnd;
                    newText = ReplaceToUpper(text, regionStart, regionEnd);
                    

                }

                indexStart = ;
            }

            text = newText;
            text = SubstringRemover(text, startString);
            text = SubstringRemover(text, endString);
        }

        
        Console.WriteLine(text);
    }

    private static string ReplaceToUpper(string text, int regionStart, int regionEnd)
    {
        int regionLenght = regionEnd - regionStart;
        string toReplace = text.Substring(regionStart, regionLenght);
        string upperCase = toReplace.ToUpper();
        string newText = text.Replace(toReplace, upperCase);
        return newText;
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

    private static string SubstringRemover(string text, string substring)
    {
        int index = text.IndexOf(substring);
        string newText = text.Remove(index, substring.Length);
        return newText;
    }
}