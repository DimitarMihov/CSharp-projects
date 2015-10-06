using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Fighter : Machine, IFighter
    {
        
        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 200d;
            this.StealthMode = stealthMode;
            this.HasDefence = false;
        }


        public override void Attack(string target)
        {
            Targets.Add(target);
        }


        public void ToggleStealthMode()
        {
            if (this.StealthMode == true)
            {
                this.StealthMode = false;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
