using System;
using System.IO;

class InsertNumberedLines
{
    /*Write a program that reads a text file and inserts line numbers in front of each of its lines.
     * The result should be written to another text file.*/

    
    static void Main()
    {
        StreamReader sourceFile = new StreamReader(@"..\..\..\TestFiles\Ex_3\InsertNumbers_s.txt");

        using (sourceFile)
        {
            int count = 1;
            string line = sourceFile.ReadLine();
            StreamWriter targetFile = new StreamWriter(@"..\..\..\TestFiles\Ex_3\InsertNumbers_t.txt", false);
            using (targetFile)
            {
                while (line != null)
                {

                    targetFile.WriteLine("Line {0}: {1}", count, line);
                    count++;
                    line = sourceFile.ReadLine();
                } 
            }
        }

        Console.WriteLine("A new file was created succesfully!");
    }
}