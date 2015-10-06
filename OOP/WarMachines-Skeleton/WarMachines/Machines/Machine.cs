using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    abstract class Machine : IMachine
    {
        public string Name { get; set; }


        public IPilot Pilot { get; set; }


        public double HealthPoints { get; set; }


        public double AttackPoints { get; set; }


        public double DefensePoints { get; set; }

        public bool DefenseMode { get; set; }

        public bool HasDefence { get; set; }

        public bool StealthMode { get; set; }


        public IList<string> Targets { get; set; }


        public Machine(string name, double attackPoints, double defencePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.Targets = new List<string>();
        }

        public abstract void Attack(string target);
        


        public abstract override string ToString();
        
    }
}
