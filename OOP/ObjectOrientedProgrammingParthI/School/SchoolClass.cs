using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class SchoolClass : IComments
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string className;

        public SchoolClass(Student[] students, Teacher[] teachers, string className)
        {
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
            this.className = className;
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
            set
            {
            }
        }

        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }
            set
            {
            }
        }

        public string ClassName
        {
            get
            {
                return this.className;
            }
            set
            {
                this.className = value;
            }
        }

        /// <summary>
        /// Implements interface IComment
        /// </summary>
        public string SetComment
        {
            get
            {
                return this.SetComment;
            }
            set
            {
                this.SetComment = value;
            }
        }

        public void PrintComment(string comment = null)
        {
            string currentComment;
            if (comment != null)
            {
                currentComment = comment;
            }
            else
            {
                currentComment = this.SetComment;
            }

            Console.WriteLine("{0}'s comment: {1}", this.ClassName, this.SetComment);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
    }
}
