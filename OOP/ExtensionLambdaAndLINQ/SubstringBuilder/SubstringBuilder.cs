/*Implement an extension method Substring(int index, int length) for the class StringBuilder
 * that returns new StringBuilder and has the same functionality as Substring in the class String.
 */


using System;
using System.Collections.Generic;
using System.Text;

public static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder strBuild, int index, int lenght)
    {
        char[] destArray = new char[lenght];
        strBuild.CopyTo(index, destArray, 0, lenght);
        string output = new string(destArray);
        return output;
    }

    static void Main()
    {
        StringBuilder sBuilder = new StringBuilder();
        char letter = 'a';
        for (int i = 0; i < 26; i++)
        {
            sBuilder.Append(letter);
            letter++;
        }

        Console.WriteLine(sBuilder.ToString());
        string substring = sBuilder.Substring(5, 10);
        Console.WriteLine(substring);

    }
}
    

