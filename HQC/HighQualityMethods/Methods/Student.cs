using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public DateTime DateOfBirth { get; private set; }
        public string OtherInfo { get; set; }

        public Student(string firstName, string lastName, string dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = DateTime.Parse(dateOfBirth);
        }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = false;

            if (this.DateOfBirth < other.DateOfBirth)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }
}
