using System;
using System.Collections.Generic;
using System.Text;

namespace W26W4IntroToLinq
{
    // primary constructor
    public class Employee(string firstName, string lastName, double salary)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public double Salary { get; set; } = salary;

        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {Salary,10:C}";
        }
    }
}
