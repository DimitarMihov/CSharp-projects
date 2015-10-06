using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class MagicWords
    {
        static void Main(string[] args)
        {
            int numWords = int.Parse(Console.ReadLine());

            List<string> wordsList = new List<string>();
            for (int i = 0; i < numWords; i++)
            {
                wordsList.Add(Console.ReadLine());
            }

            
            for (int i = 0; i < numWords; i++)
            {
                
                int key = (wordsList[i].Length % (numWords + 1));
                if (key >= numWords )
                {
                    key = numWords - 1;
                }
                string toMove = wordsList[i];
                wordsList.RemoveAt(i);
                wordsList.Insert(key, toMove);
            }

            int maxLenght = 0;
            foreach (var item in wordsList)
            {
                if (item.Length > maxLenght)
                {
                    maxLenght = item.Length;
                }
            }

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < maxLenght; i++)
            {
                foreach (var item in wordsList)
                {
                    if (i < item.Length)
                    {
                        output.Append(item[i]);
                    }
                }
            }

            string final = output.ToString();
            Console.WriteLine(final);
        }
    }
}
