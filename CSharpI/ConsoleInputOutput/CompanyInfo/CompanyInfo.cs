namespace CompanyInfo
{
    //A company has name, address, phone number, fax number, web site and manager.
    //The manager has first name, last name, age and a phone number.
    //Write a program that reads the information about a company and its manager and prints them on the console.

    
    using System;

    class CompanyInfo
    {
        static void Main()
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Enter company address: ");
            string companyaddress = Console.ReadLine();

            Console.Write("Enter company phone number: ");
            string companyPhoneNumber = Console.ReadLine();

            Console.Write("Enter company fax number: ");
            string companyFaxNumber = Console.ReadLine();

            Console.Write("Enter company website: ");
            string companyWebSite = Console.ReadLine();

            Console.Write("Enter manager's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter manager's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter manager's age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Enter manager's phone number: ");
            string managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("Company's name is {0}", companyName);
            Console.WriteLine("Company's address is {0}", companyaddress);
            Console.WriteLine("Company's phone number is {0}", companyPhoneNumber);
            Console.WriteLine("Company's fax number is {0}", companyFaxNumber);
            Console.WriteLine("Company's website is {0}", companyWebSite);
            Console.WriteLine("Manager's first name is {0}", firstName);
            Console.WriteLine("Manager's last name is {0}", lastName);
            Console.WriteLine("Manager's age is {0}", age);
            Console.WriteLine("Manager's phone number is {0}", managerPhoneNumber);
        }
    }
}
