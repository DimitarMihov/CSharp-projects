using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPerson
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name, int? age=null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}", this.Name, this.Age != null ? this.Age.ToString() : "unknown");
        }
    }
}
