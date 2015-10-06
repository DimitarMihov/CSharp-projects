using System;
using System.Text.RegularExpressions;

class ReplaceAHrefWithURL
{
    /*Write a program that replaces in a HTML document given as
     * string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string aHrefTag = @"<\s*a\s[^>]*\bhref\s*=\s*" +
                          @"('(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>\S*))[^>]*>" + 
                          @"(?<content>(.|\s)*?)<\s*/a\s*>";

        string urlTag = @"[URL=${url}]${content}[/URL]";

        string newText = Regex.Replace(text, aHrefTag, urlTag);

        Console.WriteLine(text);
        Console.WriteLine(newText);
    }
}
