using System;

class Program
    {
        static void Main()
        {
            // Takes in number entered, multiplies by 50 and gives the results
            Console.WriteLine("Pick a number:");
            string userNumber1 = Console.ReadLine();
            Console.WriteLine("Your number times 50 is: " + Convert.ToInt32(userNumber1) * 50);

            // Takes in number entered, adds 25 and gives the results
            Console.WriteLine("Pick a number:");
            string userNumber2 = Console.ReadLine();
            int plus25 = Convert.ToInt32(userNumber2) + 25;
            Console.WriteLine("Your number plus 25 is: " + plus25);

            // Takes in number entered, divides by 12.5 and gives the results
            Console.WriteLine("Pick a number:");
            string userNumber3 = Console.ReadLine();
            // Converting to a double because we need to divide by a number with a decimal
            Console.WriteLine("Your number divided by 12.5 is: " + Convert.ToDouble(userNumber3) / 12.5);
            
            // Takes in number entered, checks if it is greater than 50 and gives true/false
            Console.WriteLine("Pick a number:");
            string userNumber4 = Console.ReadLine();
            // Converting number entered to an integer and then creating boolean statement
            bool checkNum4 = Convert.ToInt32(userNumber4) > 50;
            Console.WriteLine("Is your number greater than 50?: " + checkNum4);

            // Takes in number entered, divides by 7 and gives the remainder
            Console.WriteLine("Pick a number:");
            string userNumber5 = Console.ReadLine();
            Console.WriteLine("The remainder after your number is divided by 7 is: " + Convert.ToInt32(userNumber5) % 7);
            Console.ReadLine();
    }
    }
