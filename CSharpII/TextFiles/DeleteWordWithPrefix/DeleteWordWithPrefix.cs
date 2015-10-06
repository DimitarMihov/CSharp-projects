using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DeleteTestPrefixwords
{
    class DeleteTestPrefixwords
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../mytemp01.txt";//the dir of the .cs file
            EditFile(firstFileName);

            PrintFile(firstFileName);
        }

        private static void EditFile(string firstFileName)
        {
            List<string> fileInfo = new List<string>();
            using (StreamReader sourceFile = new StreamReader(firstFileName))
            {
                string line = sourceFile.ReadLine();
                string pattern = "\\btest\\w*";
                while (line != null)
                {
                    Regex rgx = new Regex(pattern);
                    line = rgx.Replace(line, "");
                    fileInfo.Add(line);
                    line = sourceFile.ReadLine();
                }
            }

            using (StreamWriter destinationFile = new StreamWriter(firstFileName))
            {
                for (int i = 0; i < fileInfo.Count; i++)
                {
                    destinationFile.WriteLine(fileInfo[i]);
                }
            }
        }

        private static void PrintFile(string newFileName)
        {
            Console.Write("Do You want to read the concatenated file <y/n>: ");
            char answer = (char)Console.Read();

            if (answer == 'y')
            {
                using (StreamReader concatenated = new StreamReader(newFileName))
                {
                    string line = concatenated.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = concatenated.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}


