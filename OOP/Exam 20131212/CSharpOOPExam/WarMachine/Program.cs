﻿	using System;
    using System.Collections.Generic;
    using System.Linq;
	using System.Text;
	using System.Threading.Tasks;


	public class WarMachinesProgram
    {
        public static void Main()
        {
            WarMachineEngine.Instance.Start();
        }
    }
	
	///////////////////////////////////////////////////////////////////
	
    public class Command : ICommand
    {
        private const char SplitCommandSymbol = ' ';

        private string name;
        private IList<string> parameters;

        private Command(string input)
        {
            this.TranslateInput(input);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IList<string> Parameters
        {
            get
            {
                return this.parameters;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of strings cannot be null.");
                }

                this.parameters = value;
            }
        }

        public static Command Parse(string input)
        {
            return new Command(input);
        }

        private void TranslateInput(string input)
        {
            var indexOfFirstSeparator = input.IndexOf(SplitCommandSymbol);

            this.Name = input.Substring(0, indexOfFirstSeparator);
            this.Parameters = input.Substring(indexOfFirstSeparator + 1).Split(new[] { SplitCommandSymbol }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
	
	/////////////////////////////////////////////////////////////////////
	

   
    public class MachineFactory : IMachineFactory
    {
        public IPilot HirePilot(string name)
        {
            return new Pilot(name);
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            return new Tank(name, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            return new Fighter(name, attackPoints, defensePoints, stealthMode);
        }
    }

	////////////////////////////////////////////////////////////////////////////

    public sealed class WarMachineEngine : IWarMachineEngine
    {
        private const string InvalidCommand = "Invalid command name: {0}";
        private const string PilotHired = "Pilot {0} hired";
        private const string PilotExists = "Pilot {0} is hired already";
        private const string TankManufactured = "Tank {0} manufactured - attack: {1}; defense: {2}";
        private const string FighterManufactured = "Fighter {0} manufactured - attack: {1}; defense: {2}; stealth: {3}";
        private const string MachineExists = "Machine {0} is manufactured already";
        private const string MachineHasPilotAlready = "Machine {0} is already occupied";
        private const string PilotNotFound = "Pilot {0} could not be found";
        private const string MachineNotFound = "Machine {0} could not be found";
        private const string MachineEngaged = "Pilot {0} engaged machine {1}";
        private const string InvalidMachineOperation = "Machine {0} does not support this operation";
        private const string FighterOperationSuccessful = "Fighter {0} toggled stealth mode";
        private const string TankOperationSuccessful = "Tank {0} toggled defense mode";
        private const string InvalidAttackTarget = "Tank {0} cannot attack stealth fighter {1}";
        private const string AttackSuccessful = "Machine {0} was attacked by machine {1} - current health: {2}";

        private static readonly WarMachineEngine SingleInstance = new WarMachineEngine();

        private IMachineFactory factory;
        private IDictionary<string, IPilot> pilots;
        private IDictionary<string, IMachine> machines;

        private WarMachineEngine()
        {
            this.factory = new MachineFactory();
            this.pilots = new Dictionary<string, IPilot>();
            this.machines = new Dictionary<string, IMachine>();
        }

        public static WarMachineEngine Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = Console.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = Command.Parse(currentLine);
                commands.Add(currentCommand);

                currentLine = Console.ReadLine();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                string commandResult;

                switch (command.Name)
                {
                    case "HirePilot":
                        var pilotName = command.Parameters[0];
                        commandResult = this.HirePilot(pilotName);
                        reports.Add(commandResult);
                        break;

                    case "Report":
                        var pilotReporting = command.Parameters[0];
                        commandResult = this.PilotReport(pilotReporting);
                        reports.Add(commandResult);
                        break;

                    case "ManufactureTank":
                        var tankName = command.Parameters[0];
                        var tankAttackPoints = double.Parse(command.Parameters[1]);
                        var tankDefensePoints = double.Parse(command.Parameters[2]);
                        commandResult = this.ManufactureTank(tankName, tankAttackPoints, tankDefensePoints);
                        reports.Add(commandResult);
                        break;

                    case "DefenseMode":
                        var defenseModeTankName = command.Parameters[0];
                        commandResult = this.ToggleTankDefenseMode(defenseModeTankName);
                        reports.Add(commandResult);
                        break;

                    case "ManufactureFighter":
                        var fighterName = command.Parameters[0];
                        var fighterAttackPoints = double.Parse(command.Parameters[1]);
                        var fighterDefensePoints = double.Parse(command.Parameters[2]);
                        var fighterStealthMode = command.Parameters[3] == "StealthON" ? true : false;
                        commandResult = this.ManufactureFighter(fighterName, fighterAttackPoints, fighterDefensePoints, fighterStealthMode);
                        reports.Add(commandResult);
                        break;

                    case "StealthMode":
                        var stealthModeFighterName = command.Parameters[0];
                        commandResult = this.ToggleFighterStealthMode(stealthModeFighterName);
                        reports.Add(commandResult);
                        break;

                    case "Engage":
                        var selectedPilotName = command.Parameters[0];
                        var selectedMachineName = command.Parameters[1];
                        commandResult = this.EngageMachine(selectedPilotName, selectedMachineName);
                        reports.Add(commandResult);
                        break;

                    case "Attack":
                        var attackingMachine = command.Parameters[0];
                        var defendingMachine = command.Parameters[1];
                        commandResult = this.AttackMachines(attackingMachine, defendingMachine);
                        reports.Add(commandResult);
                        break;

                    default:
                        reports.Add(string.Format(InvalidCommand, command.Name));
                        break;
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
            }

            Console.Write(output.ToString());
        }

        private string HirePilot(string name)
        {
            if (this.pilots.ContainsKey(name))
            {
                return string.Format(PilotExists, name);
            }

            var pilot = this.factory.HirePilot(name);
            this.pilots.Add(name, pilot);

            return string.Format(PilotHired, name);
        }

        private string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.machines.ContainsKey(name))
            {
                return string.Format(MachineExists, name);
            }

            var tank = this.factory.ManufactureTank(name, attackPoints, defensePoints);
            this.machines.Add(name, tank);

            return string.Format(TankManufactured, name, attackPoints, defensePoints);
        }

        private string ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            if (this.machines.ContainsKey(name))
            {
                return string.Format(MachineExists, name);
            }

            var fighter = this.factory.ManufactureFighter(name, attackPoints, defensePoints, stealthMode);
            this.machines.Add(name, fighter);

            return string.Format(FighterManufactured, name, attackPoints, defensePoints, stealthMode == true ? "ON" : "OFF");
        }

        private string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!this.pilots.ContainsKey(selectedPilotName))
            {
                return string.Format(PilotNotFound, selectedPilotName);
            }

            if (!this.machines.ContainsKey(selectedMachineName))
            {
                return string.Format(MachineNotFound, selectedMachineName);
            }

            if (this.machines[selectedMachineName].Pilot != null)
            {
                return string.Format(MachineHasPilotAlready, selectedMachineName);
            }

            var pilot = this.pilots[selectedPilotName];
            var machine = this.machines[selectedMachineName];

            pilot.AddMachine(machine);
            machine.Pilot = pilot;

            return string.Format(MachineEngaged, selectedPilotName, selectedMachineName);
        }

        private string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!this.machines.ContainsKey(attackingMachineName))
            {
                return string.Format(MachineNotFound, attackingMachineName);
            }

            if (!this.machines.ContainsKey(defendingMachineName))
            {
                return string.Format(MachineNotFound, defendingMachineName);
            }

            var attackingMachine = this.machines[attackingMachineName];
            var defendingMachine = this.machines[defendingMachineName];

            if (attackingMachine is ITank && defendingMachine is IFighter && (defendingMachine as IFighter).StealthMode)
            {
                return string.Format(InvalidAttackTarget, attackingMachineName, defendingMachineName);
            }

            attackingMachine.Targets.Add(defendingMachineName);

            var attackPoints = attackingMachine.AttackPoints;
            var defensePoints = defendingMachine.DefensePoints;

            var damage = attackPoints - defensePoints;

            if (damage > 0)
            {
                var newHeathPoints = defendingMachine.HealthPoints - damage;

                if (newHeathPoints < 0)
                {
                    newHeathPoints = 0;
                }

                defendingMachine.HealthPoints = newHeathPoints;
            }

            return string.Format(AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
        }

        private string PilotReport(string pilotReporting)
        {
            if (!this.pilots.ContainsKey(pilotReporting))
            {
                return string.Format(PilotNotFound, pilotReporting);
            }

            return this.pilots[pilotReporting].Report();
        }

        private string ToggleFighterStealthMode(string stealthModeFighterName)
        {
            if (!this.machines.ContainsKey(stealthModeFighterName))
            {
                return string.Format(MachineNotFound, stealthModeFighterName);
            }

            if (this.machines[stealthModeFighterName] is ITank)
            {
                return string.Format(InvalidMachineOperation, stealthModeFighterName);
            }

            var machineAsFighter = this.machines[stealthModeFighterName] as IFighter;
            machineAsFighter.ToggleStealthMode();

            return string.Format(FighterOperationSuccessful, stealthModeFighterName);
        }

        private string ToggleTankDefenseMode(string defenseModeTankName)
        {
            if (!this.machines.ContainsKey(defenseModeTankName))
            {
                return string.Format(MachineNotFound, defenseModeTankName);
            }

            if (this.machines[defenseModeTankName] is IFighter)
            {
                return string.Format(InvalidMachineOperation, defenseModeTankName);
            }

            var machineAsFighter = this.machines[defenseModeTankName] as ITank;
            machineAsFighter.ToggleDefenseMode();

            return string.Format(TankOperationSuccessful, defenseModeTankName);
        }
    }

	////////////////////////////////////////////////////////////////////////////
	



    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }

	

    public interface IFighter : IMachine
    {
        bool StealthMode { get; }

        void ToggleStealthMode();
    }

    /// <summary>
    /// ///////////////////////////////////////////
    /// </summary>
    public interface IMachine
    {
        string Name { get; set; }

        IPilot Pilot { get; set; }

        double HealthPoints { get; set; }

        double AttackPoints { get; }

        double DefensePoints { get; }

        IList<string> Targets { get; }

        void Attack(string target);

        string ToString();
    }




    public interface IMachineFactory
    {
        IPilot HirePilot(string name);

        ITank ManufactureTank(string name, double attackPoints, double defensePoints);

        IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode);
    }

	

    public interface IPilot
    {
        string Name { get; }

        void AddMachine(IMachine machine);

        string Report();
    }

	

    public interface ITank : IMachine
    {
        bool DefenseMode { get; }

        void ToggleDefenseMode();
    }

	

    public interface IWarMachineEngine
    {
        void Start();
    }
	
	/////////////////////////////////////////////////////////////////////
	

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
            this.Targets.Add(target);
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

	/////////////////////////////////////////////////////////////////
	

    class Machine : IMachine
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

        public virtual void Attack(string target)
        {
            
        }
        


        public override string ToString()
        {
            return this.GetType().ToString();
        }
        
    }

	//////////////////////////////////////////////////////////////////////////////

    class Pilot : IPilot
    {
        public string Name { get; private set; }

        List<IMachine> machines = new List<IMachine>();

        public Pilot (string name)
        {
            this.Name = name;
        }
        

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendFormat("{0} - ", this.Name); // Pilot's name
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
                    report.AppendFormat("{0} {1}", numberOfMachines, machineTitle); // add machine's count
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
                    if (machineInstance.Targets.Count == 0)
                    {
                        report.AppendFormat("*Targets: None\n");
                    }
                    else
                    {
                        report.Append("*Targets: ");
                        for (int i = 0; i < machineInstance.Targets.Count(); i++)
                        {
                            report.AppendFormat("{0}", machineInstance.Targets[i]);
                            if (i != (machineInstance.Targets.Count() - 1))
                            {
                                report.Append(", ");
                            }

                            
                        }

                        report.Append("\n");
                    }

                    if (machineInstance is ITank)
                    {
                        report.Append("*Defense: ");
                        if ((machineInstance as ITank).DefenseMode)
                        {
                            report.Append("ON");
                        }
                        else
                        {
                            report.Append("ON");
                        }

                        report.Append("\n");
                    }

                    if (machineInstance is IFighter)
                    {
                        report.Append("*Stealth: ");
                        if ((machineInstance as IFighter).StealthMode)
                        {
                            report.Append("ON");
                        }
                        else
                        {
                            report.Append("ON");
                        }

                        report.Append("\n");
                    }

                    
                }
            }

            return report.ToString();
        }
    }

	////////////////////////////////////////////////////////////////////////////
	

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
            this.Targets.Add(target);
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


	







