using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Cat : Animal
    {
        public Cat(int age) : base(age)
        {}
        
        public Cat(int age, string name,string sound = "Miau miau!")
        {
            this.Sound = sound;
        }
        public Cat(int age, string name, string sex, string sound="Miau miau!") : base(age, name, sex)
        {
            this.Sound = sound;
        }
    }
}
