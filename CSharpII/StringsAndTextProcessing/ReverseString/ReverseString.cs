using System;

class ReverseString
{
    /*Write a program that reads a string, reverses it and prints the result at the console.
      Example: "sample"  "elpmas".*/

    
    static void Main()
    {
        Console.Write("Please, write something: ");
        string something = Console.ReadLine();
        Console.WriteLine();

        for (int i = 1; i <= something.Length; i++)
        {
            Console.Write(something[something.Length - i]);
        }

        Console.WriteLine();
    }
}
