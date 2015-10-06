/*Task 1
 * Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address,
 * mobile phone, e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and 
 * faculties.
 * Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * Task2
 * Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object
 * of type Student.
 * Task3
 * Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
 * and by social security number (as second criteria, in increasing order).
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDefineStudent1to3
{
    class TasksDefineStudent1to3
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(123456789, University.SofiaUniversity, Faculty.HistoryFaculty, Specialty.History, 2, "Ivan", "Petrov");

            Console.WriteLine(student1.ToString());

            Student student2 = student1.Clone();

            Console.WriteLine(student2.ToString());

            student2.LastName = "Ivanov";
            student2.SSN = 987654321;

            Console.WriteLine(student2.ToString());

            Console.WriteLine(student1.CompareTo(student2));
        }
    }
}
