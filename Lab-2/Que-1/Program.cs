//It allows methods to be passed as parameters, stored as data, and invoked dynamically

using System;


delegate int Sum(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        
        Sum addition = new Sum(Add);

        
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        
        int result = addition(num1, num2);

        
        Console.WriteLine($"The sum of {num1} and {num2} is {result}");
    }

    
    static int Add(int a, int b)
    {
        return a + b;
    }
}
