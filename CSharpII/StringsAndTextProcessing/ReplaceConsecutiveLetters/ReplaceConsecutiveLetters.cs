using System;
using System.Text;

class ReplaceConsecutiveLetters
{
    /*Write a program that reads a string from the console and
     * replaces all series of consecutive identical letters with
     * a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa"*/
    
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssazsxb";
        StringBuilder result = new StringBuilder();

        for (int i = 1; i < str.Length; i++)
        {
            while (i < str.Length && str[i] == str[i - 1]) i++;
            result.Append(str[i - 1]);
        }
        if (str[str.Length - 1] != str[str.Length - 2]) result.Append(str[str.Length - 1]);
        str = result.ToString();
        Console.WriteLine(str);
    }
}
