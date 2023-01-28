using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Creating abstract class Person
    public abstract class Person
    {
        // Setting up string properties for first and last name
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Creating abstract method SayName
        public abstract void SayName();
    }
}
