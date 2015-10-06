using System;
using System.IO;
using System.Diagnostics;
using System.Text;

class OnlyTextWithoutTags
{
    static void Main()
    {
        string fileName = "testFile.txt";
        Random randomGenerator = new Random();

        string[] words = { "bla", "blabla", "blablabla", "blablablabla", "bla bla" };


        StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
        using (writer)
        {
            for (int i = 1; i <= 10; i++)
            {
                writer.Write("<{0}>{1}", words[randomGenerator.Next(words.Length)], randomGenerator.Next(2) == 0 ? "\r\n" : "");
                writer.Write("{0}(Text{1}){2}",
                    randomGenerator.Next(2) == 0 ? "\r\n" : "",
                    i,
                    randomGenerator.Next(2) == 0 ? "\r\n" : "");
                writer.Write("</{0}>{1}", words[randomGenerator.Next(words.Length)], randomGenerator.Next(2) == 0 ? "\r\n" : "");
            }
        }


        Console.WriteLine("Writing only text (without tags and new lines).");
        StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            bool writeLetter = false;
            int letterCode = reader.Read();
            while (letterCode != -1)
            {
                if (letterCode == '>')
                {
                    writeLetter = true;
                }
                if (letterCode == '<')
                {
                    writeLetter = false;
                }
                if (writeLetter && letterCode != '>' && letterCode != '\r' && letterCode != '\n')
                {
                    Console.Write((char)letterCode);
                }
                letterCode = reader.Read();
            }
        }
        Console.WriteLine();

        Process openFile = new Process();
        openFile.StartInfo.FileName = fileName;
        openFile.Start();
    }
}

