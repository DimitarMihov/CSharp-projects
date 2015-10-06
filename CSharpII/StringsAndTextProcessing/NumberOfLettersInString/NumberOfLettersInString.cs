using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class NumberOfLettersInString
{
    /*Write a program that reads a string from the console and prints all
     * different letters in the string along with information how many times
     * each letter is found.*/ 

    
    static void Main()
    {
        string text = "abcdaabcdaaabbccdeaaaabbbccde";

        string regex = "\\w";
        Regex letters = new Regex(regex);
        MatchCollection matches = letters.Matches(text);
        List<string> elements = new List<string>();
        foreach (var item in matches)
        {
            elements.Add(item.ToString());
        }

        elements.Sort();
        List<List<object>> countedElements = new List<List<object>>();
        
        int counter = 1;
        string current = elements[0];
        for (int i = 1; i < elements.Count; i++)
        {
            List<object> countElement = new List<object>();
            if (elements[i] == elements[i-1])
            {
                counter++;
            }
            else
            {
                countElement.Add(current);
                countElement.Add(counter);
                counter = 1;
                countedElements.Add(countElement);
            }
            current = elements[i];
        }

        foreach (var item in countedElements)
        {
            Console.WriteLine("Letter: {0}\tCount: {1}", item[0], item[1]);
        }
        
    }
}
