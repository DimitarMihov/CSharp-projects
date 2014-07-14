namespace GreatestOfFiveVariables
{
    //Task 7 - Write a program that finds the greatest of given 5 variables.
    
    using System;

    class GreatestOfFiveVariables
    {
        static void Main()
        {
            Console.WriteLine("Enter variable values:");
            int aVariable = int.Parse(Console.ReadLine());
            int bVariable = int.Parse(Console.ReadLine());
            int cVariable = int.Parse(Console.ReadLine());
            int dVariable = int.Parse(Console.ReadLine());
            int eVariable = int.Parse(Console.ReadLine());

            int greatestVariable = int.MinValue;

            if (aVariable > greatestVariable)
            {
                greatestVariable = aVariable;
            }

            if (bVariable > greatestVariable)
            {
                greatestVariable = bVariable;
            }

            if (cVariable > greatestVariable)
            {
                greatestVariable = cVariable;
            }

            if (dVariable > greatestVariable)
            {
                greatestVariable = dVariable;
            }

            if (eVariable > greatestVariable)
            {
                greatestVariable = eVariable;
            }

            Console.WriteLine("Greatest value is: {0}", greatestVariable);
        }
    }
}
