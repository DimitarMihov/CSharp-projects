using System;
using System.IO;
using System.Text;

class ReplaceWholeWordsInFile
{
    /*Write a program that replaces all occurrences of the substring "start"
     * with the substring "finish" in a text file. Ensure it will work with
     * large files (e.g. 100 MB).
     * Modify the solution of the previous problem to replace only whole words (not substrings).*/



    static void Main()
    {
        string dirPath = @"..\..\..\TestFiles\";
        string folderName = "Ex_8";
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
            string line = sourceFile.ReadLine();
            StringBuilder wholeText = new StringBuilder();

            char[] signs = new char[] { '"', ',', '.', '-', '!', '(', ')', '[', ']', '{', '}', ' ', '\'', ':', '\\', '/', '\t', '\r', '\n', '?' };
            string newLine = null;
            while (line != null)
            {
                for (int i = 0; i < signs.Length; i++)
                {
                    for (int j = 0; j < signs.Length; j++)
                    {
                        string currentWord = signs[i] + oldString + signs[j];
                        string newWord = signs[i] + newString + signs[j];

                        if (line.Contains(currentWord))
                        {
                            newLine = line.Replace(currentWord, newWord);
                        }

                        line = newLine;
                    }
                }

                foreach (var item in newLine)
                {
                    wholeText.Append(item);
                }
                line = sourceFile.ReadLine();
            }

            return wholeText;
        }
    }
}
