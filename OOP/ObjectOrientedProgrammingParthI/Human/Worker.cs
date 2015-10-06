using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }
        
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
    }
}
