using System;

namespace InterfaceExample
{
    // Define an interface named IQuittable
    interface IQuittable
    {
        // Declare a void method named Quit
        void Quit();
    }

    // Define an Employee class 
    class Employee : IQuittable
    {
        // Properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }

    class Program
    {
        //Entry point of the console application
        static void Main(string[] args)
        {
            // Create an instance of Employee and set properties
            Employee employee = new Employee()
            {
                FirstName = "Lumi",
                LastName = "Frey"
            };

            // Use polymorphism, create an object of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit method using the interface reference
            quittableEmployee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
