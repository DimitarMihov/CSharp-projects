using System;
using System.Text;

class EncodingDecodingStringWithKey
{
    static void Main()
    {
        /*Write a program that encodes and decodes a string using given
         * encryption key (cipher). The key consists of a sequence of characters.
         * The encoding/decoding is done by performing XOR (exclusive or) operation
         * over the first letter of the string with the first of the key, the
         * second – with the second, etc. When the last key character is reached,
         * the next is the first.*/

        
        string toEncode = "THE QUICK BROWN FOX JUMPED OVER THE LAZY DOG'S 1234567890";
        string key = "encryption";
        string encoded = EncoderDecoder(toEncode, key);
        string decoded = EncoderDecoder(encoded, key);
        
        Console.WriteLine("The encoded string is: {0}\n", encoded);
        Console.WriteLine("The decoded string is {0}", decoded);
    }

    private static string EncoderDecoder(string processCodec, string key)
    {
        StringBuilder target = new StringBuilder();
        for (int i = 0; i < processCodec.Length; i++)
        {
            int j = 0;
            if (j >= key.Length)
            {
                j = 0;
            }
            target.Append((char)(processCodec[i] ^ key[j]));
            j++;
        }

        string final = target.ToString();
        return final;
    }
}
