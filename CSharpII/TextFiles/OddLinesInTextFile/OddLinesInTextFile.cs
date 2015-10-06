using System;
using System.IO;

class OddLinesInTextFile
{
    //Write a program that reads a text file and prints on the console its odd lines.

    
    static void Main()
    {
        StreamReader sourceFile = new StreamReader(@"..\..\..\TestFiles\Ex_1\OddLinesInTextFile.txt");

        using (sourceFile)
        {
            int count = 1;
            string line = sourceFile.ReadLine();
            while (line != null )
            {
                if ((count % 2) > 0)
                {
                    Console.WriteLine("Line {0}: {1}", count, line);
                }

                count++;
                line = sourceFile.ReadLine();
            }
        }
    }
}
