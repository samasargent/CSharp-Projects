using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // User picks a color
        // Yellow is the right one
        // If answer is other than yellow, while loop keeps running
        Console.WriteLine("Pick a color.");
        string color = Console.ReadLine();

        bool rightColor = false;

        while (!rightColor) { 
        switch (color)
        {
            case "red":
                Console.WriteLine("You picked red. That's not the right answer.");
                Console.WriteLine("Pick a color.");
                color = Console.ReadLine();
                break;
            case "orange":
                Console.WriteLine("You picked orange. That's not the right answer.");
                Console.WriteLine("Pick a color.");
                color = Console.ReadLine();
                break;
            case "yellow":
                Console.WriteLine("You picked yellow. That's the answer!");
                rightColor = true;
                break;
            case "green":
                Console.WriteLine("You picked green. That's not the right answer.");
                Console.WriteLine("Pick a color.");
                color = Console.ReadLine();
                break;
            case "blue":
                Console.WriteLine("You picked blue. That's not the right answer.");
                Console.WriteLine("Pick a color.");
                color = Console.ReadLine();
                break;
            default:
                Console.WriteLine("That's not one of the color options. Try again.");
                Console.WriteLine("Pick a color.");
                color = Console.ReadLine();
                break;
        }
        }

        // User picks a number
        // 2 is the right one
        // If answer is other than 2, while loop keeps running
        Console.WriteLine("Pick a number between 1 and 8.");
        int number = Convert.ToInt32(Console.ReadLine());

        bool correct = number == 2;

        do
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("You guessed the right one! Congrats!");
                    correct = true;
                    break;
                case 3:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                case 8:
                    Console.WriteLine("Not the right one. Guess again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("That's not a number between 1 and 8. Try again.");
                    Console.WriteLine("Pick a number between 1 and 8.");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!correct); // While the 'correct' boolean statement is false, keep running

        Console.ReadLine();
    }
}

