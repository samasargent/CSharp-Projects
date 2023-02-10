using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // class Employee, inheriting from Person and IQuittable
    public class Employee<T> : Person, IQuittable
    {
        public List<T> Things = new List<T>();
        public List<T> EmployeeThings
        { get
            {
                return Things;
            }
          set
            {
                Things = value;
            }  
        }

        // Implementing the SayName method from Person
        public override void SayName()
        {
            // Method that writes the employee's first and last name 
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("{0} {1} would like to quit.", firstName, lastName);
        }
    }
}
