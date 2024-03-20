//In C#, a generic list is a data structure that allows you to store a collection of elements of a specified type.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}