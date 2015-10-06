/*Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value).
 * Override ToString() to display the information of a person and if age is not specified – to say so.
 * Write a program to test this functionality.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class ClassPerson
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan", 40);
            Person person2 = new Person("Dragan");

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
