using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDefineStudent1to3
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public int? PhoneNum { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public Student(int ssn, University university, Faculty faculty, Specialty specialty, byte course, string firstName, string lastName, string middleName=null, string address=null, int? phoneNum=null, string email=null)
        {
            this.SSN = ssn;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.Course = course;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Address = address;
            this.PhoneNum = phoneNum;
            this.Email = email;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator == (Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Student: Name - {0} {1}, SSN - {2}",this.FirstName, this.LastName, this.SSN);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
        
        public Student Clone()
        {
            Student newStudent = new Student(this.SSN, this.University, this.Faculty, this.Specialty, this.Course, this.FirstName, this.LastName, this.MiddleName, this.Address, this.PhoneNum, this.Email);

            return newStudent;

        }

        public int CompareTo(Student student)
        {
            if (this.LastName.CompareTo(student.LastName) != 0)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            else
            {
                if (this.SSN == student.SSN)
                {
                    return 0;
                }
                else if (this.SSN < student.SSN)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
