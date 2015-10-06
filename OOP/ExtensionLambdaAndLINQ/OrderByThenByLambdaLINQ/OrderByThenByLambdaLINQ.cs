/*Using the extension methods OrderBy() and ThenBy() with lambda expressions
 * sort the students by first name and last name in descending order.
 * Rewrite the same with LINQ.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OrderByThenByLambdaLINQ
{
    
    static void Main()
    {
        var students = new[]
        { new {first = "Petar", last = "Stoianov", age = 16},
          new {first = "Petar", last = "Ivanov", age = 16},
          new {first = "Ivan", last = "Angelov", age = 18},
          new {first = "Georgi", last = "Boev", age = 24},
          new {first = "Stoian", last = "Yanakiev", age = 26},
        };

        //Sorted with Lambda expression
        Console.WriteLine("Sorted with Lambda expression");
        var sortedLambda = students.OrderByDescending(x => x.first).ThenByDescending(x => x.last);
        foreach (var item in sortedLambda)
        {
            Console.WriteLine("First name: {0},\tLast name: {1}", item.first, item.last);
        }


        //Sorted with LINQ
        Console.WriteLine("\nSorted with LINQ");
        var sortedLINQ =
            from student in students
            orderby student.first descending, student.last descending
            select student;

        foreach (var item in sortedLINQ)
        {
            Console.WriteLine("First name: {0},\tLast name: {1}", item.first, item.last);
        }
    }
}
