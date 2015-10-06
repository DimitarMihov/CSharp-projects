using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Tomcat : Cat
    {
        public Tomcat(int age) : base(age)
            {}
        
        public Tomcat(int age, string name) : base(age, name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = "male";
        }
    }
}
