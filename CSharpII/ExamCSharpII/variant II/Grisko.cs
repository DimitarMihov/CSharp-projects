using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant_II
{
    class Grisko
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            //int different = 1;
            int equal = 1;
            bool impossible = false;
            int possible = 1;
            string different = word[0].ToString();
            char[] arrayChars = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                arrayChars[i] = word[i];
            }

            Array.Sort(arrayChars);

            while (true)
            {
                int maxEqual = 0;
                for (int i = 1; i < word.Length - 1; i++)
                {
                    if (arrayChars[i-1] == arrayChars[i])
                    {
                        equal++;
                        if (equal > maxEqual)
                        {
                            maxEqual = equal;
                        }
                    }
                    else
                    {
                        equal = 1;
                    }

                    if (!different.Contains(word[i]))
                    {
                        different = different + word[i];
                    }
                }

                if (word.Length % 2 == 0)
                {
                    if (maxEqual >= ((word.Length / 2) + 1))
                    {
                        impossible = true;
                        break;
                    }
                }
                else
                {
                    if (maxEqual >= ((word.Length / 2) + 2))
                    {
                        impossible = true;
                        break;
                    }
                }

                
                for (int i = 1; i <= different.Length; i++)
                {
                    possible = possible * i;
                }

                break; 
            }

            if (impossible)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(possible);
            }

            
        }
    }
}
