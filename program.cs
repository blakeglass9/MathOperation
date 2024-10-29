using System;

namespace MathApp // Ensure this matches the namespace in MathOperations.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter a number
            Console.WriteLine("Enter a number to perform math operations on:");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            // Call AddTen method and display the result
            int resultAdd = mathOps.AddTen(userInput);
            Console.WriteLine($"Adding 10 to {userInput} gives: {resultAdd}");

            // Call MultiplyByTwo method and display the result
            int resultMultiply = mathOps.MultiplyByTwo(userInput);
            Console.WriteLine($"Multiplying {userInput} by 2 gives: {resultMultiply}");

            // Call SubtractFive method and display the result
            int resultSubtract = mathOps.SubtractFive(userInput);
            Console.WriteLine($"Subtracting 5 from {userInput} gives: {resultSubtract}");

            // Pause to allow the user to see the output
            Console.ReadKey();
        }
    }
}
