using System;
using System.Text.RegularExpressions;

class ExtractTitleFromHTML
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        for (int i = 0; i < text.Length; i++)
        {
            MatchCollection matches = Regex.Matches(text, @"(?<=^|>)[^><]+?(?=<|$)");

            if (i == text.Length - 1)
            {
                foreach (var words in matches)
                    Console.WriteLine(words);
            }
        }
    }
}
