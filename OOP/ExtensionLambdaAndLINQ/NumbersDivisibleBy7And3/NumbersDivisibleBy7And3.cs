/*Write a program that prints from given array of integers all numbers
 * that are divisible by 7 and 3. Use the built-in extension methods
 * and lambda expressions. Rewrite the same with LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersDivisibleBy7And3
{
    static void Main()
    {
        Random rand = new Random();
        List<int> ints = new List<int>();
        Console.WriteLine("The array of integers is: ");
        for (int i = 0; i < 200; i++)
        {
            int randomInt = rand.Next(0, 201);
            ints.Add(randomInt);
            Console.Write("{0}, ", randomInt);
        }

        //Using Lambda expressions
        Console.WriteLine("\nUsing Lambda expressions");
        List<int> divisibleLambda = ints.FindAll(x=> ((x % 7 == 0) && (x % 3 == 0)));
        foreach (var item in divisibleLambda)
        {
            Console.Write("{0}, ", item);
        }

        //Using LINQ
        Console.WriteLine("\nUsing LINQ");
        var divisibleLINQ =
            from divisible in ints
            where divisible % 7 == 0 && divisible % 3 == 0
            select divisible;

        foreach (var item in divisibleLINQ)
        {
            Console.Write("{0}, ", item);
        }

        Console.WriteLine();
    }
}
