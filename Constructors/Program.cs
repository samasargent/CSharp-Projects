using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)

        {   // Creating a const variable
            const string name = "Bob Jones";
            Console.WriteLine(name);

            // Creating a variable using keyword 'var'
            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("h:mm tt"));

            // Instantiating the class Student with name "Jimmy Neutron"
            // This is the version of the class where the student id is set by default to 10
            Student jimmy = new Student("Jimmy", "Neutron");
            Console.WriteLine($"{jimmy.FirstName} {jimmy.LastName}, #{jimmy.StudentId}");

            Console.ReadLine();
        }

    }
    public class Student
    {
        // Chaining two constructors together
        public Student(string fname, string lname) : this(10, fname, lname) 
        { 
        }

        // Creating a constructor Student
        public Student(int Id, string fname, string lname)
        {
            StudentId = Id;
            FirstName = fname;
            LastName = lname;
        }
        
        // Creating a Student class with properties student ID, first name and last name
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

