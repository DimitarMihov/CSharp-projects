using System;
using System.IO;

class CatTwoIntoOne
{
    //Write a program that concatenates two text files into another text file.

    
    static void Main()
    {
            StreamReader sourceFileOne = new StreamReader(@"..\..\..\TestFiles\Ex_2\CatTwoIntoOne_1.txt");
            using (sourceFileOne)
            {
                StreamReader sourceFileTwo = new StreamReader(@"..\..\..\TestFiles\Ex_2\CatTwoIntoOne_2.txt");
                using (sourceFileTwo)
                {
                    string fileOne = sourceFileOne.ReadToEnd();
                    string fileTwo = sourceFileTwo.ReadToEnd();

                    StreamWriter result = new StreamWriter(@"..\..\..\TestFiles\Ex_2\CatTwoIntoOne_3.txt");
                    using (result)
                    {
                        result.WriteLine(fileOne + fileTwo);
                    }
                }
            }

        Console.WriteLine("A new file was created succesfully!");
    }
}
