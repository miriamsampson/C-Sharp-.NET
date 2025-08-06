using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Prompt the user to select an index for the string array
        Console.WriteLine("Select an index (0 to 4) to view a fruit from the string array:");
        string stringInput = Console.ReadLine();

        // Try to parse the input and access the array
        if (int.TryParse(stringInput, out int stringIndex))
        {
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine($"You selected: {stringArray[stringIndex]}");
            }
            else
            {
                // Display error message for invalid index
                Console.WriteLine("Error: Index out of range for string array.");
            }
        }
        else
        {
            // Display error message for invalid input
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }

        Console.WriteLine(); // Add a blank line for readability

        // Create a one-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Prompt the user to select an index for the integer array
        Console.WriteLine("Select an index (0 to 4) to view a number from the integer array:");
        string intInput = Console.ReadLine();

        // Try to parse the input and access the array
        if (int.TryParse(intInput, out int intIndex))
        {
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine($"You selected: {intArray[intIndex]}");
            }
            else
            {
                // Display error message for invalid index
                Console.WriteLine("Error: Index out of range for integer array.");
            }
        }
        else
        {
            // Display error message for invalid input
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }

        Console.WriteLine(); // Add a blank line for readability

        // Create a list of strings
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

        // Prompt the user to select an index for the list
        Console.WriteLine("Select an index (0 to 4) to view a color from the list:");
        string listInput = Console.ReadLine();

        // Try to parse the input and access the list
        if (int.TryParse(listInput, out int listIndex))
        {
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the string at the selected index
                Console.WriteLine($"You selected: {stringList[listIndex]}");
            }
            else
            {
                // Display error message for invalid index
                Console.WriteLine("Error: Index out of range for list.");
            }
        }
        else
        {
            // Display error message for invalid input
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }

        // Wait for user to press a key before closing the console
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}