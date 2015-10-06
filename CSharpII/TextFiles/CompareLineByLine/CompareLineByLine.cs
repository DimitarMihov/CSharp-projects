using System;
using System.IO;

class CompareLineByLine
{
    /*Write a program that compares two text files line by line
     * and prints the number of lines that are the same and the
     * number of lines that are different. Assume the files have
     * equal number of lines.*/

    
    static void Main()
    {
        string folderName = "Ex_4";
        string fileName1 = "\\File_1.txt";
        string fileName2 = "\\File_2.txt";

        int countDiff = 0;
        int countSame = 0;

        StreamReader sourceFileOne = new StreamReader(@"..\..\..\TestFiles\" +folderName+ fileName1);
        using (sourceFileOne)
        {
            StreamReader sourceFileTwo = new StreamReader(@"..\..\..\TestFiles\" + folderName + fileName2);
            using (sourceFileTwo)
            {
                
                string line1 = sourceFileOne.ReadLine();
                string line2 = sourceFileTwo.ReadLine();

                while (line1 != null)
                {
                    if (line1.CompareTo(line2) == 0)
	                {
                        countSame++;
	                }
                    else
                    {
                        countDiff++;
                    }

                    line1 = sourceFileOne.ReadLine();
                    line2 = sourceFileTwo.ReadLine();
                }
            }
        }

        Console.WriteLine("Lines with the same content       -- : {0}", countSame);
        Console.WriteLine("Lines with the different content  -- : {0}", countDiff);
    }
}
