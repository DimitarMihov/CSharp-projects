using System;

namespace Methods
{
    class TestMethods
    {
       

        static void Main()
        {
            Console.WriteLine(GeometryCalculations.CalcTriangleArea(3, 4, 5));
            Console.WriteLine(ProcessingNumbers.ConvertDigitToWord(5));
            Console.WriteLine(ProcessingNumbers.FindMax(5, -1, 3, 2, 14, 2, 3));

            ProcessingNumbers.PrintFormatted(1.3, "f");
            ProcessingNumbers.PrintFormatted(0.75, "%");
            ProcessingNumbers.PrintFormatted(2.30, "r");

            Console.WriteLine(Distance.Calculate(3, -1, 5, 2.5));
            Console.WriteLine("The line is horizontal: {0}", Distance.CheckPlane(3, 3));
            Console.WriteLine("The line is vertical: {0}", Distance.CheckPlane(-1, 2.5));

            Student peter = new Student("Peter", "Ivanov", "17.03.1992");
            peter.OtherInfo = "From Sofia";

            Student stella = new Student("Stella", "Markova", "03.11.1993");
            stella.OtherInfo = "From Vidin, gamer, high results";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
