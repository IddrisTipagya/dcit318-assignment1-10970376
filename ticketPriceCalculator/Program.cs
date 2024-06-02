using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Check if the input is a valid integer
            if (int.TryParse(input, out age) && age >= 0)
            {
                // Determine the ticket price based on the age
                decimal ticketPrice = CalculateTicketPrice(age);

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        // Function to calculate the ticket price based on the age
        static decimal CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return 7.0m; // Discounted price for seniors and children
            }
            else
            {
                return 10.0m; // Regular price
            }
        }
    }
}
