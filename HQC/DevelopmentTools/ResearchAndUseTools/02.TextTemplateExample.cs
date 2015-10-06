using System;

 

class Person {
 public string FirstName = String.Empty;
 public string MiddleName = String.Empty;
 public string LastName = String.Empty;
 public string EmailAddress = String.Empty;
 public string Sign = String.Empty;

    public Person(string firstName,string middleName,string lastName,string emailAddress,string sign)
        {
                this.FirstName = firstName;
                this.MiddleName = middleName;
                this.LastName = lastName;
                this.EmailAddress = emailAddress;
                this.Sign = sign;
        }
}