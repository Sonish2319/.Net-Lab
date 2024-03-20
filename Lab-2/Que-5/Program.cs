using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a Dictionary to store CustomerId and CustomerName
        Dictionary<int, string> customers = new Dictionary<int, string>();

        // Add some customers to the dictionary
        customers.Add(1, "John Doe");
        customers.Add(2, "Alice Smith");
        customers.Add(3, "Bob Johnson");

        // Print CustomerId and CustomerName
        Console.WriteLine("Customer Details:");
        foreach (var customer in customers)
        {
            Console.WriteLine($"CustomerId: {customer.Key}, CustomerName: {customer.Value}");
        }
    }
}
