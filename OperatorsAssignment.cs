using System;

namespace EmployeeComparisonApp
{
    // Define Employee class
    class Employee
    {
        // Property to hold employees ID
        public int Id { get; set; }

        // Property to hold employees first name
        public string FirstName { get; set; }

        // Property to hold employees last name
        public string LastName { get; set; }

        // Overload '==' operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null, but not both, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to complement the '==' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match the behavior of the overloaded '=='
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return this == other;
            return false;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign values
            Employee employee1 = new Employee()
            {
                Id = 101,
                FirstName = "Lumi",
                LastName = "Frey"
            };

            // Create second Employee object and assign values
            Employee employee2 = new Employee()
            {
                Id = 102,
                FirstName = "Mari",
                LastName = "Lou"
            };

            // Compare two employees using the overloaded '==' operator
            bool areEqual = employee1 == employee2;

            // Display result of the comparison
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Keep console window open
            Console.ReadLine();
        }
    }
}
