using System;

class CalculateDaysBetweenDates
{
    /*Write a program that reads two dates in the format:
     * day.month.year and calculates the number of days between them.*/
    
    static void Main()
    {
        Console.Write("Please enter a start date: ");
        DateTime localStart = DateTime.Parse(Console.ReadLine());
        Console.Write("Please enter an end date: ");
        DateTime localEnd = DateTime.Parse(Console.ReadLine());
        int daysCount = (localEnd - localStart).Days;
        Console.WriteLine("There are {0} days between them.", daysCount);
    }
}
