using System;
using System.Collections.Generic;

class Dictionary
{
    /*A dictionary is stored as a sequence of text lines
     * containing words and their explanations. Write a program
     * that enters a word and translates it by using the dictionary. */
    
    static void Main()
    {
        List<string> dictionary = new List<string>() {
        ".NET – platform for applications from Microsoft",
        "CLR – managed execution environment for .NET",
        "namespace – hierarchical organization of classes"
        };
        
        Console.Write("Enter a word to search: ");
        string search = Console.ReadLine();
        Console.WriteLine();

        for (int i = 0; i < dictionary.Count; i++)
        {
            if (dictionary[i].IndexOf(search) == 0)
            {
                Console.WriteLine(dictionary[i]);
            }
        }

        Console.WriteLine();
    }
}