using System;

class Program
    {
        static void Main()
        {

        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        
        // Takes in package weight, checks using if weight is greater than 50.
        // If not greater than 50, proceeds to next step, getting the width.
        // If greater, stops there.
        Console.WriteLine("Please enter the package's weight.");
        int packageWeight = Convert.ToInt32(Console.ReadLine());

        if (packageWeight > 50) 
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }

        else
        {
            Console.WriteLine("Please enter the package's width.");
            //Takes in package height and length.
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package's height.");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package's length.");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //Adds all package dimensions together, and if greater than 50, stops there.
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            //If not greater than 50, calculates quote by multiplying the package dimensions together
            // Then mutiples that by package weight and divides by 100
            else
            {
                int quote = (((packageWidth * packageHeight * packageLength) * packageWeight) / 100);
                decimal finalQuote = quote + 0.00m; // Converts quote into format that will show dollar amount
                Console.WriteLine("Your estimated total for shipping this package is: $" + finalQuote);
            }
        }

        Console.ReadLine();

        }
    }
