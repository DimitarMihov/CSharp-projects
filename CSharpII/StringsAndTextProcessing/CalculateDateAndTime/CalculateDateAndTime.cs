using System;
using System.Globalization;

class CalculateDateAndTime
{
    /*Write a program that reads a date and time given in the format:
     * day.month.year hour:minute:second and prints the date and time
     * after 6 hours and 30 minutes (in the same format) along with
     * the day of week in Bulgarian.*/

    
    static void Main()
    {
        DateTimeFormatInfo bg = CultureInfo.CreateSpecificCulture("bg-BG").DateTimeFormat;
        Console.Write("Please enter a start date: ");
        string dateTimeString = Console.ReadLine(); 
        DateTime localStart = ConvertToDateTime(dateTimeString);
        DateTime localEnd = localStart.AddHours(6.5);
        Console.WriteLine("New date is {0}, and the day is {1}", localEnd, localEnd.ToString("dddd", new CultureInfo("bg-BG")));
   }

    private static DateTime ConvertToDateTime(string value)
    {
        DateTime convertedDate = new DateTime();
        try
        {
            convertedDate = Convert.ToDateTime(value);
            
        }

        catch (FormatException)
        {
            Console.WriteLine("'{0}' is not in the proper format.", value);
        }

        return convertedDate;

    }
}
