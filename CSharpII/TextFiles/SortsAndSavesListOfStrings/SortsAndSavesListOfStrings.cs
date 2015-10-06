using System;
using System.IO;
using System.Collections.Generic;

class SortsAndSavesListOfStrings
{
    /*Write a program that reads a text file containing a list of strings,
     * sorts them and saves them to another text file.*/
    
    static void Main()
    {
        string dirPath = @"..\..\..\TestFiles\";
        string folderName = "Ex_6";
        string source = @"\Source.txt";
        string target = @"\Target.txt";

        List<string> toSort = new List<string>();
        StreamReader sourceFile = new StreamReader(dirPath + folderName + source);
        using(sourceFile)
	    {
            
            string line = sourceFile.ReadLine();
            while (line != null)
            {
                toSort.Add(line);
                line = sourceFile.ReadLine();
            }

            toSort.Sort();

	    }

        StreamWriter targetFile = new StreamWriter(dirPath + folderName + target);
        using (targetFile)
        {
            foreach (var name in toSort)
            {
                targetFile.WriteLine(name);
            }
        }

        Console.WriteLine("Target file was created!");
    }
}
