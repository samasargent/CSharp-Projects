using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new SchoolContext()) 
            {
                var stud = new Student() { StudentName = "Joe Smith" };

                context.Students.Add(stud);
                context.SaveChanges();
            }
        }
    }
}
