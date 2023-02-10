using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee object 
            // with first name "Sample" and last name "Student"
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student" };

            // Calling superclass method SayName
            employee1.SayName();

            Console.ReadLine();
        }
    }
}
