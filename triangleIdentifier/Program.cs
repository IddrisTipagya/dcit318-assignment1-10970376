using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the lengths of the three sides
            Console.Write("Enter the length of side 1: ");
            double side1 = GetSideLength();
            
            Console.Write("Enter the length of side 2: ");
            double side2 = GetSideLength();
            
            Console.Write("Enter the length of side 3: ");
            double side3 = GetSideLength();

            // Determine the type of the triangle
            string triangleType = DetermineTriangleType(side1, side2, side3);

            // Display the type of the triangle
            Console.WriteLine($"The triangle is: {triangleType}");
        }

        // Function to get the length of a side
        static double GetSideLength()
        {
            double length;
            while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
            return length;
        }

        // Function to determine the type of the triangle
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
