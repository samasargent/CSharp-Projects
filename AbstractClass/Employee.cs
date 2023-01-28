using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // class Employee, inheriting from Person
    public class Employee : Person
    {
        // Implementing the SayName method from Person
        public override void SayName()
        {
            // Method that writes the employee's first and last name 
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
