using System;
using System.Collections.Generic;
using System.IO;

class DeleteAllOddLinesOfSameFiles
{
    static void Main()
    {
        string filename = "..//..//testfile.txt";
        StreamReader sr = new StreamReader(filename);
        string row = sr.ReadLine();
        int count = 0;
        List<string> rows = new List<string>();
        while (row != null)
        {

            if (count % 2 == 0)
            {
                rows.Add(row);
            }
            row = sr.ReadLine();
            count++;
        }
        sr.Close();

        StreamWriter sw = new StreamWriter(filename, false);
        for (int i = 0; i < rows.Count; i++)
        {
            sw.WriteLine(rows[i]);
        }
        sw.Close();

    }
}

