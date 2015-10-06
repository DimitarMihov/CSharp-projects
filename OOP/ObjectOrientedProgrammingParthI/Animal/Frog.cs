using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Frog : Animal
    {
        public Frog(int age) : base(age)
        {}
        
        public Frog(int age, string name, string sex, string sound="Kwa Kwa!") : base(age, name, sex)
        {
            this.Sound = sound;
        }
    }
}
