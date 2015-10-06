using System;

class HelloNameMethod
{
    static void Main()
    {
        GetName();
    }

    private static void GetName()
    {
        Console.Write("What is your name? : ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Thank you {0}!", name);
        //Console.WriteLine();
        //Console.Write("Your name is: {0}", name);
        Console.WriteLine();
    }
}
