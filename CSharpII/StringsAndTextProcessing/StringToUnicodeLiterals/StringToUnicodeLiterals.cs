using System;

class StringToUnicodeLiterals
{
    /* Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.*/
    
    static void Main()
    {
        string text = "Hi!";
        string result = "";
        foreach (var item in text)
        {
            string newText = "\\u" + ((int)item).ToString("x4");
            result += newText;
        }

        Console.WriteLine(result);

    }
}
