using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Prompt the user to enter a number to divide each list item by
        Console.WriteLine("Enter a number to divide each item in the list by:");

        // Read user input
        string userInput = Console.ReadLine();

        try
        {
            // Attempt to convert the user input to an integer
            int divisor = Convert.ToInt32(userInput);

            // Loop through each number in the list
            foreach (int number in numbers)
            {
                // Divide the current number by the user-provided divisor
                int result = number / divisor;

                // Display the result to the screen
                Console.WriteLine($"{number} divided by {divisor} equals {result}");
            }
        }
        catch (DivideByZeroException ex)
        {
            // Handle division by zero specifically
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine($"System message: {ex.Message}");
        }
        catch (FormatException ex)
        {
            // Handle invalid input (e.g., string instead of number)
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine($"System message: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"System message: {ex.Message}");
        }

        // This message confirms that the program continued after the try/catch block
        Console.WriteLine("\nProgram has exited the try/catch block and continued execution.");

        // Wait for user to press a key before closing the console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}