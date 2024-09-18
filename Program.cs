using System;

class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare Employee objects by their Id
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Id == employee2.Id;
    }

    // Overloading the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded operators
        if (employee1 == employee2)
        {
            Console.WriteLine("Employee 1 and Employee 2 are equal.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 2 are not equal.");
        }
    }
}

