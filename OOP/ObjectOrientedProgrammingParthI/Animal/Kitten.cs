using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Kitten : Cat
    {
        public Kitten(int age) : base(age)
            {}
        
        public Kitten(int age, string name) : base(age, name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = "female";
        }
    }
}
