using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating two Employee objects  
            Employee employee1 = new Employee() { Id = 001, FirstName = "John", LastName = "Smith" };
            Employee employee2 = new Employee() { Id = 002, FirstName = "Jake", LastName = "Jones" };

            // Using overloaded == to check if the two employees have the same ID
            Console.WriteLine(employee1 == employee2 ? "Both employees have the same id." : "These are two different employees.");

            // Using overloaded != to check if the two employees have different IDs
            Console.WriteLine(employee1 != employee2 ? "These employees have the same id." : "These employees are not the same."); 
            
            Console.ReadLine();
        }
    }
}
