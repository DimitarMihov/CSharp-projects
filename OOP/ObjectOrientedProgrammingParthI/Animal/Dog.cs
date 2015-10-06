using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    
    class Dog : Animal
    {
        public Dog(int age) : base(age)
        {}
        
        public Dog(int age, string name, string sex, string sound="Bau bau!") : base(age, name, sex)
        {
            this.Sound = sound;
        }
    }
}
