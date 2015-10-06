using System;
using System.Collections.Generic;

class HexadecimalToDecimalConversion
{
    //Write a program to convert hexadecimal numbers to their decimal representation.
    
    static void Main()
    {
        Console.Write("Please, enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();

        List<int> hexList = new List<int>();
        int hexDec = 0;
        bool breakApp = false;
        foreach (var element in hexNum)
        {
            hexDec = element - 48;
            switch (hexDec)
            {
                case 0: hexList.Add(hexDec); break;
                case 1: hexList.Add(hexDec); break;
                case 2: hexList.Add(hexDec); break;
                case 3: hexList.Add(hexDec); break;
                case 4: hexList.Add(hexDec); break;
                case 5: hexList.Add(hexDec); break;
                case 6: hexList.Add(hexDec); break;
                case 7: hexList.Add(hexDec); break;
                case 8: hexList.Add(hexDec); break;
                case 9: hexList.Add(hexDec); break;
                case 17: hexList.Add(hexDec - 7); break;
                case 18: hexList.Add(hexDec - 7); break;
                case 19: hexList.Add(hexDec - 7); break;
                case 20: hexList.Add(hexDec - 7); break;
                case 21: hexList.Add(hexDec - 7); break;
                case 22: hexList.Add(hexDec - 7); break;

                default: breakApp = true;
                    break;
            }
        }

        if (breakApp)
        {
            Console.WriteLine("Entered number is not a hexadecimal!");
        }
        else
        {
            hexList.Reverse();
            int n = hexList.Count;
            int decNum = 0;
            for (int i = 0; i < n; i++)
            {
                double power = Math.Pow(16, i);
                decNum += hexList[i] * (int)power;
            }

            Console.WriteLine("The decimal equivalent of the number is: {0}", decNum);
        }
    }
}
