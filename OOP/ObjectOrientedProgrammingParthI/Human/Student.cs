﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    public class Student : Human
    {
        public int Grade { get; set; }
        
        public Student(string firstName, string lastName,int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
