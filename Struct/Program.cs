using System;

namespace Struct
{
    class Program
    {
        // Creating a struct called Number with the property Amount of data type decimal
        struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            // Creating a Number object "money" with Amount equal to 15.00
            Number money = new Number() { Amount = 15.00m };

            // Writing Amount to screen
            Console.WriteLine(money.Amount);
            Console.ReadLine();
        }
    }
}
