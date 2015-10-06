using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    class Loan : Account
    {
        public Loan(Customer customer, string depositStart, decimal balance, decimal interestRate) :
            base(customer, depositStart, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterestAmount()
        {
            if (this.Customer.customerType == CustomerType.Individual)
            {
                if (this.DepositLenghtInMonths() < 3)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (this.DepositLenghtInMonths() - 3);
                }
            }
            else
            {
                if (this.DepositLenghtInMonths() < 2)
                {
                    return 0;
                }
                else
                {
                    return this.InterestRate * (this.DepositLenghtInMonths() - 2);
                }
                
            }
        }
    }
}
