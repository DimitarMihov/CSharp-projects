using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public DateTime AccountStart { get; private set; }
        public Customer Customer;

        public Account(Customer customer, string depositStart, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.AccountStart = DateTime.Parse(depositStart);
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal DepositLenghtInMonths()
        {
            double span = (DateTime.Now - this.AccountStart).Days / 30;
            return (decimal)span;
        }
        public virtual decimal CalculateInterestAmount()
        {
            return this.InterestRate * this.DepositLenghtInMonths();
        }

        public void Deposit(decimal money)
        {
            this.Balance = this.Balance + money;
        }
    }

    
}
