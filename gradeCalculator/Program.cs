using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a numerical grade
            Console.Write("Enter a numerical grade between 0 and 100: ");
            string input = Console.ReadLine();
            int grade;

            // Check if the input is a valid integer and within the range
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade = GetLetterGrade(grade);

                // Display the corresponding letter grade
                Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
            }
        }

        // Function to determine the letter grade based on the numerical grade
        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
