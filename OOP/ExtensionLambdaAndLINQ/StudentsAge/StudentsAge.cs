/*Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StudentsAge
{
    static void Main()
    {
        var students = new[]
        { new {first = "Petar", last = "Stoianov", age = 16},
          new {first = "Ivan", last = "Angelov", age = 18},
          new {first = "Georgi", last = "Boev", age = 24},
          new {first = "Stoian", last = "Yanakiev", age = 26},
        };

        var before =
            from student in students
            where student.age >= 18 && student.age <= 24
            select new { First = student.first, Last = student.last };

        foreach (var item in before)
        {
            Console.WriteLine("First name: {0},\tLast name: {1}", item.First, item.Last);
        }
    }
}
