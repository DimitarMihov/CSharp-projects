using System;
using System.Collections.Generic;

class SToDConversion
{
    //Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

    
    static void Main()
    {
        Console.Write("Please, enter a base of numeral system to convert from: ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine();
        while (s < 2)
        {
            Console.Write("The number must be larger than 2: ");
            s = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        Console.Write("Please, enter a base of numeral system to convert to: ");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine();
        while (d > 16)
        {
            Console.Write("The number must be smaller than 16: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        Console.Write("Please, enter a number to convert: ");
        string number = Console.ReadLine();
        Console.WriteLine();

        if (s == 10) //convert from base 10
        {
            char[] hexDec = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int decNum = int.Parse(number);

            List<char> hexaDecimal = new List<char>();
            int hexNum = 0;
            char element = ' ';
            while (decNum > 0)
            {
                hexNum = (decNum % d);
                element = hexDec[hexNum];
                hexaDecimal.Add(element);
                decNum = decNum / d;
            }

            hexaDecimal.Reverse();
            Console.Write("The number with the base {0} is: ", d);
            foreach (var member in hexaDecimal)
            {
                Console.Write(member);
            }
            Console.WriteLine();
        }
        else if (d == 10) //convert to base 10
        {
            
            
            List<int> hexList = new List<int>();
            int hexDec = 0;
            bool breakApp = false;
            foreach (var element in number)
            {
                hexDec = element - 48;
                if (hexDec >= s)
                {
                    Console.WriteLine("The number is not in defined numeral sistem!\nThe result woud not be valid!\nPlease, go back and enter a correct number!");
                }
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
                    double power = Math.Pow(s, i);
                    decNum += hexList[i] * (int)power;
                }

                Console.WriteLine("The decimal equivalent of the number is: {0}", decNum);
            }
        }
        else // convert from s to d through 10
        {
            List<int> hexList = new List<int>();
            int hexDec = 0;
            bool breakApp = false;
            foreach (var element in number)
            {
                hexDec = element - 48;
                if (hexDec >= s)
                {
                    Console.WriteLine("The number is not in defined numeral sistem!\nThe result woud not be valid!\nPlease, go back and enter a correct number!");
                }

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
                //convert from base s to 10
                hexList.Reverse();
                int n = hexList.Count;
                int decNum = 0;
                for (int i = 0; i < n; i++)
                {
                    double power = Math.Pow(s, i);
                    decNum += hexList[i] * (int)power;
                }

                //Console.WriteLine("The decimal equivalent of the number is: {0}", decNum);

                // convert from base 10 to base d

                char[] hexChar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                List<char> hexaDecimal = new List<char>();
                int hexNum = 0;
                char element = ' ';
                while (decNum > 0)
                {
                    hexNum = (decNum % d);
                    element = hexChar[hexNum];
                    hexaDecimal.Add(element);
                    decNum = decNum / d;
                }

                hexaDecimal.Reverse();
                Console.Write("The number with the base {0} is: ", d);
                foreach (var member in hexaDecimal)
                {
                    Console.Write(member);
                }
                Console.WriteLine();
            }
        }
    }
}
