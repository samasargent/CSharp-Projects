using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        // Setting up properties for ID and first and last name
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // In order to overload == and !=, we need to also overload Equals() and GetHashCode()
        public override bool Equals(object employee)
        {
            // If parameter is null, return false
            if (employee == null) 
            { return false; }

            // If paramater is not the same type, return faslse
            if (employee.GetType() != typeof(Employee))
            { return false; }
            
            var employee1 = (Employee)employee;
            // Return true if fields match
            return Id == employee1.Id;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        // Overloading == to check if the two employee IDs are equal to each other
        public static bool operator ==(Employee employeeLeft, Employee employeeRight)
        {
            // If yes, they are the same, return true
            if (employeeLeft.Id == employeeRight.Id)
            {
                return true;
            }
            // If no, they are not the same, return false
            else
            {
                return false;
            }
        }
        
        // Overloading !=, because we have to if we are overloading ==
        // Checks if the employee IDs are NOT equal to each other
        public static bool operator !=(Employee employeeLeft, Employee employeeRight)
        {
            // If yes, they are not the same, return false
            if (employeeLeft.Id != employeeRight.Id)
            {
                return false;
            }
            // If no, they are the same, return true
            else
            {
                return true;
            }
        }
    }
}
