using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            Student student2 = new Student();

            Student[] students = new Student[2];
            students[0] = student1;
            students[1] = student2;

            Discipline discipline1 = new Discipline(100, 20, "Math");
            Discipline discipline2 = new Discipline(200, 50, "OOP");

            Discipline[] disciplines = new Discipline[2];
            disciplines[0] = discipline1;
            disciplines[1] = discipline2;

            Teacher teacher1 = new Teacher(disciplines);
            Teacher teacher2 = new Teacher(disciplines);

            Teacher[] teachers = new Teacher[2];
            teachers[0] = teacher1;
            teachers[1] = teacher2;

            SchoolClass class1 = new SchoolClass(students, teachers, "Best");
            SchoolClass class2 = new SchoolClass(students, teachers, "Worst");

            SchoolClass[] classes = new SchoolClass[2];
            classes[0] = class1;
            classes[1] = class2;

            School school1 = new School(classes);

            Console.WriteLine(class1.ClassName);
            Console.WriteLine(class2.ClassName);
            Console.WriteLine(discipline1.Name);
        }
    }
}
