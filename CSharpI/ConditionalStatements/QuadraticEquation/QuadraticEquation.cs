namespace QuadraticEquation
{
    //Task 6 - Write a program that enters the coefficients a, b and c of a quadratic equation and calculates and prints its real roots. 
    
    using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter the coefficients of qudratic equation: a * x * x + b * x + c = 0");
            Console.Write("a = ");
            double aCoeff = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double bCoeff = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double cCoeff = double.Parse(Console.ReadLine());

            double? rootOne = null;
            double? rootTwo = null;

            //Evaluation of D
            double discriminant = (bCoeff * bCoeff) - 4 * aCoeff * cCoeff;

            //Finding roots
            if (discriminant == 0)
            {
                rootOne = (-bCoeff) / 2 * aCoeff;
                Console.WriteLine("There is only one root: x = {0}", rootOne);
            }
            else if (discriminant > 0)
            {
                rootOne = ((-bCoeff) - Math.Sqrt(discriminant)) / 2 * aCoeff;
                rootTwo = ((-bCoeff) + Math.Sqrt(discriminant)) / 2 * aCoeff;
                Console.WriteLine("There are two roots x1 = {0} and x2 = {1}", rootOne, rootTwo);
            }
            else
            {
                Console.WriteLine("There are no real roots!");
            }
        }
    }
}
