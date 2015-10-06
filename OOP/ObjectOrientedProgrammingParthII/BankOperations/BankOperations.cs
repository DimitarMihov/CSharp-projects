/*A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
 * Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based).
 * Deposit accounts are allowed to deposit and withdraw 
 * money. Loan and mortgage accounts can only deposit money.
 * All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as 
 * follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a 
 * company.
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
 * Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces,
 * base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    class BankOperations
    {
        static void Main()
        {
            Customer customer1 = new Customer("Customer 1", CustomerType.Individual);
            Customer customer2 = new Customer("Customer 2", CustomerType.Company);
            
            List<Account> accounts = new List<Account>();
            accounts.Add(new Deposit(customer1, "01.01.2013", 5000, 2));
            accounts.Add(new Loan(customer1, "01.01.2013", -10000, 3));
            accounts.Add(new Mortgage(customer1, "01.01.2013", -100000, 1.5m));

            foreach (var account in accounts)
            {
                Console.WriteLine("Interest amounth for the period of {0} months is {1}", account.DepositLenghtInMonths(), account.CalculateInterestAmount());
            }

            Deposit deposit1 = new Deposit(customer1, "01.01.2013", 3000, 2.3m);

            Console.WriteLine("The deposit balance of {0} is {1}",deposit1.Customer.Name, deposit1.Balance );

            deposit1.Withdraw(500);

            Console.WriteLine("The deposit balance of {0} is {1}", deposit1.Customer.Name, deposit1.Balance);
        }
    }
}
