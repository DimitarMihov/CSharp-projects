using System;
using System.Text.RegularExpressions;

class ExtractEmailAddress
{
    /*Write a program for extracting all email addresses
     * from given text. All substrings that match the format
     * <identifier>@<host>…<domain> should be recognized as emails.*/

    
    static void Main()
    {
        string text = "I have many email addresses - dmihov@sub.dom, dimitar.m@dom.sub and more, but the most used is \"dmihov70@gmail.com\", wich is my favourite";

        string regex = @"\b([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)\b";

        Regex email = new Regex(regex);
        MatchCollection matches = email.Matches(text);

        foreach (Match item in matches)
        {
            Console.WriteLine(item);
        }
    }
}
