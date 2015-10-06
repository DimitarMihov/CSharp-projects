using System;
using System.Linq;
using System.Reflection;
using School;

namespace SchoolDemo
{
    public class SchoolDemoUtils
    {
        static void Main(string[] args)
        {

            Course math = new Course("Math");
            for (int i = 0; i < 30; i++)
            {
               math.AddStudent(new Student("Test Student : " + i));
            }

            Console.WriteLine(math);

            math.RemoveStudentByID(10000);
            math.RemoveStudentByID(10001);
            math.RemoveStudentByID(10002);

            Console.WriteLine(math);

            SchoolDem PMG = new SchoolDem("PMG");
            PMG.AddCourse(math);
            Console.WriteLine(PMG);


            var school = new SchoolDem("Banichka");
            var course = new Course("Alg");

            school.AddCourse(course);

            Console.WriteLine(school);
        }
    }
}
