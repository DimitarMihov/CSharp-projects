using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    class Pilot : IPilot
    {
        public string Name { get; private set; }

        List<IMachine> machines;

        public Pilot (string name)
        {
            this.Name = name;
        }
        

        public void AddMachine(IMachine machine)
        {
            machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendFormat("{0} - ", this.GetType().Name); // Pilot's name
            int numberOfMachines = machines.Count;
            string machineTitle = "machines\n";
            if (numberOfMachines == 0)
            {
                report.AppendFormat("no {0}", machineTitle); // add machine's count
            }
            else
            {
                if (numberOfMachines == 1)
                {
                    report.AppendFormat("{0} machine\n", numberOfMachines);
                }
                else
                {
                    report.AppendFormat("{0} ", numberOfMachines); // add machine's count
                }

                var orderedListOfMachines = machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);

                foreach (var machineInstance in orderedListOfMachines)
                {
                    report.AppendFormat(" - {0}\n", machineInstance.Name);
                    report.AppendFormat("*Type: {0}\n", machineInstance.GetType().Name);
                    report.AppendFormat("*Health: {0}\n", machineInstance.HealthPoints);
                    report.AppendFormat("*Attack: {0}\n", machineInstance.AttackPoints);
                    report.AppendFormat("*Defense: {0}\n", machineInstance.DefensePoints);

                    // add Targets
                    if (machineInstance.Targets.Count() == 0)
                    {
                        report.AppendFormat("*Targets: None\n");
                    }
                    else
                    {
                        for (int i = 0; i < machineInstance.Targets.Count(); i++)
                        {
                            report.AppendFormat("*Targets: {0}", machineInstance.Targets[i]);
                            if (i != (machineInstance.Targets.Count() - 1))
                            {
                                report.Append(", ");
                            }

                            report.Append("\n");
                        }
                    }

                    //TODO да добавя дефенс и стелт мод

                    
                }
            }

            return report.ToString();
        }
    }
}
