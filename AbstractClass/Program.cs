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

            // Using polymorphism to create an object of type IQuittable
            IQuittable disgruntled = new Employee() { firstName = "Joe", lastName = "Jones" };

            // Calling the Quit method
            disgruntled.Quit();

            Console.ReadLine();
        }
    }
}
