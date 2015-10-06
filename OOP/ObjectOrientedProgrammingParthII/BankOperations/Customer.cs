using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    public class Customer
    {
        public string Name { get; set; }
        public CustomerType customerType;

        public Customer(string name, CustomerType customerType)
        {
            this.Name = name;
            this.customerType = customerType;
        }
    }
}
