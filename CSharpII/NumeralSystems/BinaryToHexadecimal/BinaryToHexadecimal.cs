using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).
    
    static void Main()
    {
        Console.Write("Please, enter a number in bynary format: ");
        string byNum = Console.ReadLine();
        int whole = byNum.Length / 4;
        int rem = byNum.Length % 4;
        int offset = 0;
        bool breakApp = false;
        char[] aByte = new char[4]; // тук събираме порциите от по 4 символа
        List<char> hexaDec = new List<char>(); //тук събираме частите на шестнадесетичното число

        if (rem > 0)
        {
            int i;
            for (i = 0; i < 4 - rem; i++)
            {
                aByte[i] = '0';
            }

            for (int n = i; n < 4; n++)
            {
                aByte[n] = byNum[offset];
                offset++;
            }

            // имаме първата част от 4 символа, събрани в aByte

            string hexaDecimal = new string(aByte);
            switch (hexaDecimal)
            {
                case "0000": hexaDec.Add('0'); break;
                case "0001": hexaDec.Add('1'); break;
                case "0010": hexaDec.Add('2'); break;
                case "0011": hexaDec.Add('3'); break;
                case "0100": hexaDec.Add('4'); break;
                case "0101": hexaDec.Add('5'); break;
                case "0110": hexaDec.Add('6'); break;
                case "0111": hexaDec.Add('7'); break;
                case "1000": hexaDec.Add('8'); break;
                case "1001": hexaDec.Add('9'); break;
                case "1010": hexaDec.Add('A'); break;
                case "1011": hexaDec.Add('B'); break;
                case "1100": hexaDec.Add('C'); break;
                case "1101": hexaDec.Add('D'); break;
                case "1110": hexaDec.Add('E'); break;
                case "1111": hexaDec.Add('F'); break;

                default: breakApp = true;
                    break;
            }
        }





        for (int i = 0; i < whole; i++)
        {
            for (int n = 0; n < 4; n++)
            {
                aByte[n] = byNum[offset];
                offset++;
            }

            //всяка следваща част от по 4 символа

            string hexaDecimal = new string(aByte);
            switch (hexaDecimal)
            {
                case "0000": hexaDec.Add('0'); break;
                case "0001": hexaDec.Add('1'); break;
                case "0010": hexaDec.Add('2'); break;
                case "0011": hexaDec.Add('3'); break;
                case "0100": hexaDec.Add('4'); break;
                case "0101": hexaDec.Add('5'); break;
                case "0110": hexaDec.Add('6'); break;
                case "0111": hexaDec.Add('7'); break;
                case "1000": hexaDec.Add('8'); break;
                case "1001": hexaDec.Add('9'); break;
                case "1010": hexaDec.Add('A'); break;
                case "1011": hexaDec.Add('B'); break;
                case "1100": hexaDec.Add('C'); break;
                case "1101": hexaDec.Add('D'); break;
                case "1110": hexaDec.Add('E'); break;
                case "1111": hexaDec.Add('F'); break;

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

            Console.WriteLine(string.Join("", hexaDec));
        }
    }
}
