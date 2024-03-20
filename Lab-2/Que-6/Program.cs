
// LINQ (Language-Integrated Query) in C# is a powerful feature that allows you to write
//  queries directly within your C# code to manipulate and query data from different data sources, 
// such as arrays, collections, databases, XML, and more.

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Given names
        // string[] names = { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };
        string[] names = { "Ram", "Ram", "Hari", "Bikash", "Ram" };

        // Sort names using LINQ
        var sortedNames = names.OrderBy(name => name);

        // Print sorted names
        Console.WriteLine("Sorted Names:");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}
