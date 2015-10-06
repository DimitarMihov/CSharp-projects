using System;
using System.IO;
using System.Text;

class ReplaceSubstringsInAFile
{
    /*Write a program that replaces all occurrences of the substring "start"
     * with the substring "finish" in a text file. Ensure it will work with
     * large files (e.g. 100 MB).*/

    
    static void Main()
    {
        string dirPath = @"..\..\..\TestFiles\";
        string folderName = "Ex_7";
        string source = @"\Source.txt";
        string target = @"\Target.txt";

        string oldString = "start";
        string newString = "finish";

        StringBuilder newFile = new StringBuilder();
        newFile = ReplaceStrings(dirPath, folderName, source, oldString, newString);

        StreamWriter targetFile = new StreamWriter(dirPath + folderName + target);
        using (targetFile)
        {
            targetFile.WriteLine(newFile.ToString());
        }

        Console.WriteLine("Target file was created!");
    }

    private static StringBuilder ReplaceStrings(string dirPath, string folderName, string source, string oldString, string newString)
    {
        StreamReader sourceFile = new StreamReader(dirPath + folderName + source);
        using (sourceFile)
        {
            string aFile = sourceFile.ReadToEnd();
            StringBuilder wholeFile = new StringBuilder();
            foreach (var item in aFile)
            {
                wholeFile.Append(item);
            }

            wholeFile.Replace(oldString, newString);
            return wholeFile;
        }
    }
}