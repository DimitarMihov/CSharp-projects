/*Define abstract class Human with first name and last name.
Define new class Student which is derived from Human and has new field – grade.
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class ProcessHuman
    {
        static void Main(string[] args)
        {
            //Initialize an array of 10 students and sort them by grade in ascending order.
            List<Student> students = new List<Student>()
              {
                  new Student( "Stu01","dent01", 9 ),
                  new Student( "Stu02","dent02", 7 ),
                  new Student( "Stu03","dent03", 3 ),
                  new Student( "Stu04","dent04", 4 ),
                  new Student( "Stu05","dent05", 5 ),
                  new Student( "Stu06","dent06", 8 ),
                  new Student( "Stu07","dent07", 2 ),
                  new Student( "Stu08","dent08", 1 ),
                  new Student( "Stu09","dent09", 10 ),
                  new Student( "Stu10","dent10", 6 )
              };

            Console.WriteLine("Unsorted list:");
            foreach (var item in students)
            {
                Console.WriteLine("First Name: {0}\tLast Name: {1}\tGrade: {2}", item.FirstName, item.LastName, item.Grade);
            }

             students = students.OrderBy(Student => Student.Grade).ToList();

            Console.WriteLine("Sorted list:");
            foreach (var item in students)
            {
                Console.WriteLine("First Name: {0}\tLast Name: {1}\tGrade: {2}", item.FirstName, item.LastName, item.Grade);
            }

            // Initialize an array of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>()
              {
                  new Worker( "FName01","LName01", 250, 20 ),
                  new Worker( "FName02","LName02", 350, 20 ),
                  new Worker( "FName03","LName03", 50, 20 ),
                  new Worker( "FName04","LName04", 1500, 20 ),
                  new Worker( "FName05","LName05", 800, 20 ),
                  new Worker( "FName06","LName06", 210, 20 ),
                  new Worker( "FName07","LName07", 30, 20 ),
                  new Worker( "FName08","LName08", 145, 20 ),
                  new Worker( "FName09","LName09", 731, 20 ),
                  new Worker( "FName10","LName10", 235, 20 )
              };

            Console.WriteLine("Unsorted list:");
            foreach (var item in workers)
            {
                Console.WriteLine("First Name: {0}  Last Name: {1}  Salary: {2}  Hours: {3}  Per hour: {4}", item.FirstName, item.LastName, item.WeekSalary, item.WorkHoursPerDay, item.MoneyPerHour());
            }

            workers = workers.OrderBy(Worker => Worker.MoneyPerHour()).ToList();
            workers.Reverse();

            Console.WriteLine("Sorted list:");
            foreach (var item in workers)
            {
                Console.WriteLine("First Name: {0}  Last Name: {1}  Salary: {2}  Hours: {3}  Per hour: {4}", item.FirstName, item.LastName, item.WeekSalary, item.WorkHoursPerDay, item.MoneyPerHour());
            }

            var mergedlists = workers.Concat<Human>(students).ToList();
            mergedlists = mergedlists.OrderBy(list => list.FirstName).ThenBy(list => list.LastName).ToList();

            foreach (var item in mergedlists)
            {
                Console.WriteLine("First name: {0}\tLast name: {1}", item.FirstName, item.LastName);
            }
        }
    }
}
