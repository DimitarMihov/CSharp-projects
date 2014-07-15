namespace ConvertingNumberToText
{
    //Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
    
    using System;

    class ConvertingNumberToText
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number [0...999] to convert: ");
                int numberToConvert = int.Parse(Console.ReadLine());
                string convertedText = String.Empty;

                int remainder = numberToConvert % 100;
                int hundreds = numberToConvert / 100;
                int tenth = remainder / 10;
                int digits = numberToConvert % 10;
                string hundredsText = String.Empty;
                string tenthText = String.Empty;
                string digitsText = String.Empty;

                if (numberToConvert == 0)
                {
                    convertedText = "Zero";
                }
                else
                {
                    if (hundreds > 0)
                    {
                        switch (hundreds)
                        {
                            case 1:
                                hundredsText = "One";
                                break;
                            case 2:
                                hundredsText = "Two";
                                break;
                            case 3:
                                hundredsText = "Three";
                                break;
                            case 4:
                                hundredsText = "Four";
                                break;
                            case 5:
                                hundredsText = "Five";
                                break;
                            case 6:
                                hundredsText = "Six";
                                break;
                            case 7:
                                hundredsText = "Seven";
                                break;
                            case 8:
                                hundredsText = "Eight";
                                break;
                            case 9:
                                hundredsText = "Nine";
                                break;
                            default:
                                break;
                        }

                        convertedText = hundredsText + " hundred ";

                        if (numberToConvert % 100 >=1 && numberToConvert % 100 <= 19)
                        {
                            convertedText += "and ";
                        }
                    }

                    if (tenth > 0)
                    {
                        if (tenth == 1)
                        {
                            switch (digits)
                            {
                                case 0:
                                    tenthText = "Ten";
                                    break;
                                case 1:
                                    tenthText = "Eleven";
                                    break;
                                case 2:
                                    tenthText = "Twelve";
                                    break;
                                case 3:
                                    tenthText = "Thirteen";
                                    break;
                                case 4:
                                    tenthText = "Fourteen";
                                    break;
                                case 5:
                                    tenthText = "Fifteen";
                                    break;
                                case 6:
                                    tenthText = "Sixteen";
                                    break;
                                case 7:
                                    tenthText = "Seventeen";
                                    break;
                                case 8:
                                    tenthText = "Eighteen";
                                    break;
                                case 9:
                                    tenthText = "Nineteen";
                                    break;
                                default:
                                    break;
                            }

                            convertedText = convertedText + tenthText;
                        }
                        else if(tenth > 1)
                        {
                            switch (tenth)
                            {
                                case 2:
                                    tenthText = "Twenty";
                                    break;
                                case 3:
                                    tenthText = "Thirty";
                                    break;
                                case 4:
                                    tenthText = "Fourty";
                                    break;
                                case 5:
                                    tenthText = "Fifty";
                                    break;
                                case 6:
                                    tenthText = "Sixty";
                                    break;
                                case 7:
                                    tenthText = "Seventy";
                                    break;
                                case 8:
                                    tenthText = "Eighty";
                                    break;
                                case 9:
                                    tenthText = "Ninety";
                                    break;
                                default:
                                    break;
                            }

                            convertedText = convertedText + tenthText + " ";
                        }
                    }

                    if (tenth != 1 && digits > 0)
                    {
                        switch (digits)
                        {
                            case 1:
                                digitsText = "One";
                                break;
                            case 2:
                                digitsText = "Two";
                                break;
                            case 3:
                                digitsText = "Three";
                                break;
                            case 4:
                                digitsText = "Four";
                                break;
                            case 5:
                                digitsText = "Five";
                                break;
                            case 6:
                                digitsText = "Six";
                                break;
                            case 7:
                                digitsText = "Seven";
                                break;
                            case 8:
                                digitsText = "Eight";
                                break;
                            case 9:
                                digitsText = "Nine";
                                break;
                            default:
                                break;
                        }

                        convertedText = convertedText + digitsText; 
                    }
                    
                }

                Console.WriteLine(convertedText);
            }
        }
    }
}
