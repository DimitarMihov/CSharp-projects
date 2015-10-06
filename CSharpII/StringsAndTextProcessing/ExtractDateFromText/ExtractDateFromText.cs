using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDateFromText
{
    /*Write a program that extracts from a given text all dates
     * that match the format DD.MM.YYYY. Display them in the standard
     * date format for Canada*/
    
    static void Main()
    {
        string text = "In this year as many ears before and many ears after, the christmass party will be on 24.12.2013 at 5pm. In case of emergency the party will be moved on 1.1.14 or 15.1.2014.";

        string regex = @"\b([0-9]{1,2})\.([0-9]{1,2})\.([0-9]{2,4})";
        Regex partyDates = new Regex(regex);
        MatchCollection matches = partyDates.Matches(text);
        foreach (var item in matches)
        {
            DateTime date = DateTime.Parse(item.ToString());
            Console.WriteLine(date.ToString("d", new CultureInfo("fr-CA")));
        }
    }
}
