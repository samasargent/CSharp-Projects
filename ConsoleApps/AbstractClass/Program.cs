using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace AbstractClass
{
    public class Program
    {
        static void Main()
        {
            // Instantiating an Employee object with first name 'Sample' and last name 'Student'
            Employee<string> employee = new Employee<string>() { firstName = "Sample", lastName = "Student" };

            // Calling SayName method
            employee.SayName();

            // Using polymorphism to create an object of type IQuittable
            IQuittable disgruntled = new Employee<string>() { firstName = "Joe", lastName = "Jones" };

            // Calling the Quit method
            disgruntled.Quit();

            // Instantiating an Employee object with a first and last name and a string list
            Employee<string> hasThings = new Employee<string>()
            {
                firstName = "Bill",
                lastName = "Moss",
                Things = { "paperclip", "stapler", "pencil" }
            };

            // Instantiating an Employee object with a first and last name and an integer list
            Employee<int> hasNum = new Employee<int>
            {
                firstName = "Kate",
                lastName = "Jacobs",
                Things = { 1, 7, 5, 9, 23 }
            };


            // For each loop to write the items in the list of Things for hasThings
            foreach (string thing in hasThings.Things)
            {

                Console.WriteLine(thing);
            }

            // For each loop to write the items in the list of Things for hasNum
            foreach (int thing in hasNum.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
