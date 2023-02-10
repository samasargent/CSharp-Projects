using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");

        // Takes hourly rate for person 1 and converts it to an integer
        Console.WriteLine("What is your hourly rate?");
        int hourlyRate1 = Convert.ToInt32(Console.ReadLine());

        // Takes hours worked per week for person 1 and converts it to an integer
        Console.WriteLine("How many hours do you work per week?");
        int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Person 2");
        // Takes hourly rate for person 2 and converts it to an integer
        Console.WriteLine("What is your hourly rate?");
        int hourlyRate2 = Convert.ToInt32(Console.ReadLine());

        // Takes hours worked per week for person 2 and converts it to an integer
        Console.WriteLine("How many hours do you work per week?");
        int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());

        // Takes hourly rate and hours per week for both people
        // Multiplies by 52 (number of weeks in a year) to find annual salary
        int annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
        int annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;
        Console.WriteLine("Annual salary of Person 1: " + annualSalary1);
        Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

        // Takes both annual salaries and checks to see if salary 1 is greater than salary 2
        bool p1VSp2 = annualSalary1 > annualSalary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?: " + p1VSp2);
        Console.ReadLine();
    }
    }