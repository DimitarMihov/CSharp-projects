using System;

class Program
{
    /*Write a program that reads from the console a string of maximum 20 characters.
     * If the length of the string is less than 20, the rest of the characters should
     * be filled with '*'. Print the result string into the console.*/

    
    static void Main()
    {
        Console.WriteLine("Plese, enter a string of maximum 20 characters!");
        string string20 = Console.ReadLine();
        while (string20.Length > 20)
        {
            Console.WriteLine("Plese, enter a string of maximum 20 characters!");
            string20 = Console.ReadLine();
        }

        if (string20.Length < 20)
        {
            int toAppend = 20 - string20.Length;
            string charToAppend = new String('*', toAppend);
            string20 = string.Concat(string20, charToAppend);
        }

        Console.WriteLine(string20);
    }
}
