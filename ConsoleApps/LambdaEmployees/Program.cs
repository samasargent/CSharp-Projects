using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of 10 employees
            // Two of the employees have the same first name, "Joe"
            List<Employee> employees = new List<Employee>
            {
               new Employee { Id = 1, FirstName = "Joe", LastName = "Jones" },
               new Employee { Id = 2, FirstName = "Bob", LastName = "Smith" },
               new Employee { Id = 3, FirstName = "Sue", LastName = "Doherty" },
               new Employee { Id = 4, FirstName = "Christine", LastName = "Green" },
               new Employee { Id = 5, FirstName = "John", LastName = "Watkins" },
               new Employee { Id = 6, FirstName = "Joe", LastName = "Zimmer" },
               new Employee { Id = 7, FirstName = "Dan", LastName = "Holt" },
               new Employee { Id = 8, FirstName = "Rosie", LastName = "Santos" },
               new Employee { Id = 9, FirstName = "Julie", LastName = "Collins" },
               new Employee { Id = 10, FirstName = "Arlene", LastName = "Powell" }
            };

            // Setting up a new list to use with the foreach loop
            List<Employee> joes = new List<Employee>();
            // If employee's first name is "Joe", add to the new list "joes"
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);

                }
            }

            // Writing the same action as above, but with a lambda expression
            // Write from the list of employees to new list "joeEmployees" where first name is Joe
            List<Employee> joeEmployees = employees.Where(x => x.FirstName == "Joe").ToList();

            // Write from the list of employees to new list "greaterthan5" where employee Id is greater than 5
            List<Employee> greaterthan5 = employees.Where(x => x.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
