namespace RefactoringWithBestPractices
{
    using System;
    class RefactoringWithBestPractices
    {
        public static void Main()
        {
            double[] values = { 1.5, 2.5, 3.5, 4.5, 5.6, 6, 10 };

            Statistics statisticOfValues = new Statistics(values);

            statisticOfValues.PrintStatistics();
        }
    }
}
