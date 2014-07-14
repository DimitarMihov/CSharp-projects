namespace IntDoubleString
{
    //Task 8 - Write a program that, depending on the user's choice inputs int, double or string variable.
    //If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
    //The program must show the value of that variable as a console output. Use switch statement.
    
    using System;

    class IntDoubleString
    {
        static void Main()
        {
            Console.Write("Choose type of variable - int, double or string: ");
            string typeOfVariable = Console.ReadLine();

            Console.Write("Enter the variable value: ");

            switch (typeOfVariable)
            {
                case "int":
                    int intValue = int.Parse(Console.ReadLine());
                    intValue += 1;
                    Console.WriteLine("The new value is: {0}", intValue);
                    break;
                case "double":
                    double doubleValue = double.Parse(Console.ReadLine());
                    doubleValue += 1;
                    Console.WriteLine("The new value is: {0}", doubleValue);
                    break;
                case "string":
                    string stringValue = Console.ReadLine();
                    stringValue += "*";
                    Console.WriteLine("The new value is: {0}", stringValue);
                    break;
                default:
                    break;
            }
        }
    }
}
