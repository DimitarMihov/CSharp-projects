/*Write a method that from a given array of students finds all students
 *whose first name is before its last name alphabetically.
 *Use LINQ query operators.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentsFirstLastName
{
    static void Main()
    {
        var students = new[]
        { new {first = "Petar", last = "Stoianov"},
          new {first = "Ivan", last = "Angelov"},
          new {first = "Georgi", last = "Boev"},
          new {first = "Stoian", last = "Yanakiev"},
        };

        var before =
            from student in students
            where student.first.CompareTo(student.last) == -1
            select new { First = student.first, Last = student.last };

        foreach (var item in before)
        {
            Console.WriteLine("First name: {0},\tLast name: {1}", item.First, item.Last);
        }
    }
}
