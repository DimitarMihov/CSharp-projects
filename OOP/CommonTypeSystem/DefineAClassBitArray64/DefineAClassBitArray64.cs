/*Define a class BitArray64 to hold 64 bit values inside an ulong value.
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineAClassBitArray64
{
    class DefineAClassBitArray64
    {
        static void Main(string[] args)
        {
            //Print some number in binary representation just to compare with it
            int num = 152874333;
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));
            //Making the BitArray64 with the same number but from ulong type
            ulong number = 152874333;
            BitArray64 bits1 = new BitArray64(number);
            //Test foreach
            foreach (var bit in bits1)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(new String('*', 64));
            //Making new BitArray64 and compare it with the old one
            BitArray64 bits2 = new BitArray64((ulong)912875466);
            Console.WriteLine(bits1.Equals(bits2));
            Console.WriteLine(bits1 == bits2);
            Console.WriteLine(bits1 != bits2);
            Console.WriteLine(new String('*', 64));
            //Test ToString() method
            Console.WriteLine(bits2);
            //Test overriten operator[]
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(bits2[i]);  
            }
            Console.WriteLine();
            
        }
    }
}
