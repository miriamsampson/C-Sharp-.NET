using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // One-dimensional array of strings
        string[] phrases = { "Hello", "Welcome", "Goodbye", "Thanks", "Cheers" };

        // A list of unique strings
        List<string> uniqueList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // A list with duplicate strings
        List<string> duplicateList = new List<string> { "A", "B", "C", "D", "C" };

        // Infinite loop that continues until user types "exit"
        while (true)
        {
            // Ask the user to input text to append to each item in the array
            Console.Write("\nPlease enter some text to append (or type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            // Exit condition
            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            // Append user input to each string in the array
            for (int i = 0; i < phrases.Length; i++)
            {
                phrases[i] += userInput;
            }

            // Print each updated string
            Console.WriteLine("\nUpdated strings:");
            foreach (string phrase in phrases)
            {
                Console.WriteLine(phrase);
            }

            // Loop using '<' operator
            Console.WriteLine("\nLoop using '<' operator:");
            for (int i = 0; i < phrases.Length; i++)
            {
                Console.WriteLine($"Index {i}: {phrases[i]}");
            }

            // Loop using '<=' operator
            Console.WriteLine("\nLoop using '<=' operator:");
            for (int i = 0; i <= phrases.Length - 1; i++)
            {
                Console.WriteLine($"Index {i}: {phrases[i]}");
            }

            // Ask the user to search for text in the unique list
            Console.Write("\nEnter text to search in the unique list: ");
            string searchText = Console.ReadLine();

            bool foundInUnique = false;

            // Loop through the unique list to find a match

            for (int i = 0; i < uniqueList.Count; i++)
            {
                // Use IndexOf for case-insensitive search
                if (uniqueList[i].IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Match found at index {i}: {uniqueList[i]}");
                    foundInUnique = true;
                    break; //stop after first match
                }
            }


            // Notify user if no match was found
            if (!foundInUnique)
            {
                Console.WriteLine("Your input is not on the unique list.");
            }

            // Ask the user to search for text in the duplicate list
            Console.Write("\nEnter text to search in the duplicate list: ");
            string searchDuplicate = Console.ReadLine();

            bool foundInDuplicate = false;

            // Loop through the duplicate list to find all matching indices
            for (int i = 0; i < duplicateList.Count; i++)
            {
                // Case-insensitive match
                if (duplicateList[i].Equals(searchDuplicate, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Match found at index {i}: {duplicateList[i]}");
                    foundInDuplicate = true;
                    // No break here — we want all matches
                }
            }

            // Notify user if no match was found
            if (!foundInDuplicate)
            {
                Console.WriteLine("Your input is not on the duplicate list.");
            }

            // Track seen items to detect duplicates
            HashSet<string> seenItems = new HashSet<string>();

            Console.WriteLine("\nChecking for duplicates in the list:");

            // Foreach loop to evaluate each item in the duplicate list
            foreach (string item in duplicateList)
            {
                // Check if item has already been seen
                if (seenItems.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is unique");
                    seenItems.Add(item); // Mark item as seen
                }
            }
        }
    }
}
