using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    class Mortgage : Account
    {
        public Mortgage(Customer customer, string depositStart, decimal balance, decimal interestRate) :
            base(customer, depositStart, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Customer.customerType == CustomerType.Individual)
            {
                if (this.DepositLenghtInMonths() < 6)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (this.DepositLenghtInMonths() - 6);
                }
                
            }
            else
            {
                if (this.DepositLenghtInMonths() < 12)
                {
                    return base.CalculateInterestAmount() * 0.5m;
                }
                else
                {
                    return base.CalculateInterestAmount() * 0.5m + (this.InterestRate * (this.DepositLenghtInMonths() - 12));
                }
                
            }
        }
    }
}
