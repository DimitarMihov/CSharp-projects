namespace PrintNameOfDigit
{
    //Task 5 - Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.
    
    using System;

    class PrintNameOfDigit
    {
        static void Main()
        {
            Console.Write("Enter a single digit: ");
            int digit = int.Parse(Console.ReadLine());
            string digitName = String.Empty;

            switch (digit)
            {
                case 0:
                    digitName = "Zero";
                    break;
                case 1:
                    digitName = "One";
                    break;
                case 2:
                    digitName = "Two";
                    break;
                case 3:
                    digitName = "Three";
                    break;
                case 4:
                    digitName = "Four";
                    break;
                case 5:
                    digitName = "Five";
                    break;
                case 6:
                    digitName = "Six";
                    break;
                case 7:
                    digitName = "Seven";
                    break;
                case 8:
                    digitName = "Eight";
                    break;
                case 9:
                    digitName = "Nine";
                    break;
                default:
                    digitName = String.Format("{0} is not a single digit!", digit);
                    break;
            }

            Console.WriteLine(digitName);
        }
    }
}
