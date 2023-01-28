using System;

namespace AbstractClass
{
    public class Program
    {
        static void Main()
        {
            // Instantiating an Employee object with first name 'Sample' and last name 'Student'
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            
            // Calling SayName method
            employee.SayName();
            Console.ReadLine();
        }
    }
}
