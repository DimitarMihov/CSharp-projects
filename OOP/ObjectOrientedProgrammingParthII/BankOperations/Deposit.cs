using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    class Deposit : Account
    {
        public Deposit(Customer customer, string depositStart, decimal balance, decimal interestRate) :
            base(customer, depositStart, balance, interestRate)
        {
            
        }

        public bool Withdraw(decimal money)
        {
            if ((this.Balance - money) > 0)
            {
                this.Balance = this.Balance - money;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount();
            }
        }
    }
}
