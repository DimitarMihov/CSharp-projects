using System;

class SubstringsInText
{
    /*Write a program that finds how many times a substring is contained
     * in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:*/

    
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string subString = "in";
        int index = 0; // next occurance of substring
        int n = 0; // offset for IndexOf
        int i = 0; // counter of substrings
        while (index >= 0)
        {
            index = text.IndexOf(subString, n);
            n = index + 1;
            i++;
        }

        Console.WriteLine("The substring \"{0}\" is contaned {1} times.", subString, i);
    }
}
