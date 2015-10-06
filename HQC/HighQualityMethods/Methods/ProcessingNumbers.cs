using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ProcessingNumbers
    {
        public static string ConvertDigitToWord(int number)
        {
            string numberAsString = String.Empty;

            switch (number)
            {
                case 0:
                    numberAsString = "zero";
                    break;
                case 1:
                    numberAsString = "one";
                    break;
                case 2:
                    numberAsString = "two";
                    break;
                case 3:
                    numberAsString = "three";
                    break;
                case 4:
                    numberAsString = "four";
                    break;
                case 5:
                    numberAsString = "five";
                    break;
                case 6:
                    numberAsString = "six";
                    break;
                case 7:
                    numberAsString = "seven";
                    break;
                case 8:
                    numberAsString = "eight";
                    break;
                case 9:
                    numberAsString = "nine";
                    break;
                default:
                    numberAsString = "Invalid number!";
                    break;
            }

            return numberAsString;
        }

        public static int FindMax(params int[] elements)
        {
            int maxValue = int.MinValue;

            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array is empty or not defined!");
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        public static void PrintFormatted(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
    }
}
