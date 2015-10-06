using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Tank : Machine, ITank
    {

        public Tank(string name, double attackPoints, double defencePoints)
            : base(name, attackPoints, defencePoints)
        {
            this.HealthPoints = 100d;
            this.DefenseMode = true;
            this.HasDefence = false;
        }

        public override void Attack(string target)
        {
            Targets.Add(target);
        }

        public void ToggleDefenseMode()
        {
            if (DefenseMode == true)
            {
                this.AttackPoints = this.AttackPoints - 40d;
                this.DefensePoints = this.DefensePoints + 30d;
                this.DefenseMode = false;
            }
            else
            {
                this.AttackPoints = this.AttackPoints + 40d;
                this.DefensePoints = this.DefensePoints - 30d;
                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
