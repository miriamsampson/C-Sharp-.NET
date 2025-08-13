using System;

namespace MathOperationApp
{
    // Define a class 
    class MathProcessor
    {
        // Define a void method 
        public void ProcessNumbers(int number1, int number2)
        {
            // Perform a math operation on the first integer 
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number is: " + number2);
        }
    }

    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathProcessor class
            MathProcessor processor = new MathProcessor();

            // Call the method using positional arguments
            processor.ProcessNumbers(5, 10); 

            // Call the method using named arguments
            processor.ProcessNumbers(number1: 7, number2: 3); 
        }
    }
}
