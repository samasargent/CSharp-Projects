using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        // Setting up string properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method that writes the person's first and last name 
        public void SayName() 
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
