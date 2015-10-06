using System;
using System.Collections.Generic;


class MultiverseCommunication
{
    static void Main()
    {
        string input = Console.ReadLine();
        int inputLenght = input.Length;
        string[] symbols = new string[inputLenght / 3];

        int index = 0;
        for (int i = 0; i < (inputLenght / 3); i++)
        {
            symbols[i] = input.Substring(index, 3);
            index += 3;
        }

        Dictionary<string, string> messageSymbols = new Dictionary<string, string>();

        messageSymbols.Add("CHU", "0");
        messageSymbols.Add("TEL", "1");
        messageSymbols.Add("OFT", "2");
        messageSymbols.Add("IVA", "3");
        messageSymbols.Add("EMY", "4");
        messageSymbols.Add("VNB", "5");
        messageSymbols.Add("POQ", "6");
        messageSymbols.Add("ERI", "7");
        messageSymbols.Add("CAD", "8");
        messageSymbols.Add("K-A", "9");
        messageSymbols.Add("IIA", "A");
        messageSymbols.Add("YLO", "B");
        messageSymbols.Add("PLA", "C");

        string message = "";
        foreach (var item in symbols)
        {
            message = message + messageSymbols[item];   
        }

        List<long> hexList = new List<long>();
        int hexDec = 0;
        foreach (var element in message)
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

                default: 
                    break;
            }
        }

            hexList.Reverse();
            long n = hexList.Count;
            long decNum = 0;
            for (int i = 0; i < n; i++)
            {
                double power = Math.Pow(13, i);
                decNum += hexList[i] * (long)power;
            }

            Console.WriteLine(decNum);


    }
}
