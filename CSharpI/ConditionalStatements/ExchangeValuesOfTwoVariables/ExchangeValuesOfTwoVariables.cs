namespace ExchangeValuesOfTwoVariables
{
    //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

    using System;

    class ExchangeValuesOfTwoVariables
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers:");

            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int storeVariable;

            if (firstInteger > secondInteger)
            {
                storeVariable = firstInteger;
                firstInteger = secondInteger;
                secondInteger = storeVariable;
            }

            Console.WriteLine("First integer: {0}", firstInteger);
            Console.WriteLine("Second integer: {0}", secondInteger);
        }
    }
}
