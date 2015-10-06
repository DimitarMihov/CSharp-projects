using System;
using System.Collections.Generic;

class SignedShortToBinary
{
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
    
    static void Main()
    {
        Console.Write("Please, enter a decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        if (decNum < 0)
        {
            decNum = (Math.Abs(decNum) - 1);
            List<byte> byteNum = new List<byte>();
            byte element = 0;
            while (decNum > 0)
            {
                element = (byte)(decNum % 2);
                byteNum.Add(element);
                decNum = (short)(decNum / 2);
            }

            byteNum.Reverse();
            List<byte> binNum = new List<byte>();
            int rem = byteNum.Count;
            int i;
            for (i = 0; i < 16 - rem; i++)
            {
                binNum.Add(0);
            }

            foreach (var member in byteNum)
            {
                binNum.Add(member);
            }
            foreach (var member in binNum)
            {
                Console.Write(member > 0 ? 0 : 1);
            }
            Console.WriteLine();
        }
        else
        {
            List<byte> byteNum = new List<byte>();
            byte element = 0;
            while (decNum > 0)
            {
                element = (byte)(decNum % 2);
                byteNum.Add(element);
                decNum = (short)(decNum / 2);
            }

            byteNum.Reverse();
            foreach (var member in byteNum)
            {
                Console.Write(member);
            }
            Console.WriteLine();
        }
    }
}
