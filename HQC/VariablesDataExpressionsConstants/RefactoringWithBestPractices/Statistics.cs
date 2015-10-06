namespace RefactoringWithBestPractices
{
    using System;
    class Statistics
    {
        public double[] Values { get; set; }

        public Statistics(double[] values)
        {
            this.Values = values;
        }
        
        public void PrintStatistics()
        {
            Console.WriteLine("Max value of the array is: {0}", FindMaxValue());
            Console.WriteLine("Min value of the array is: {0}", FindMinValue());
            Console.WriteLine("Average value of the array is: {0}", FindAverageValue());
        }

        public double FindMaxValue()
        {
            double maxValue = double.MinValue;

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] > maxValue)
                {
                    maxValue = Values[i];
                }
            }

            return maxValue;
        }

        public double FindMinValue()
        {
            double minValue = double.MaxValue;

            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] < minValue)
                {
                    minValue = Values[i];
                }
            }

            return minValue;
        }

        public double FindAverageValue()
        {
            double averageValue = 0;
            double sumOfValues = 0;
            int countOfValues = Values.Length;

            for (int i = 0; i < countOfValues; i++)
            {
                sumOfValues += Values[i];
            }

            averageValue = sumOfValues / countOfValues;

            return averageValue;
        }
    }
}
