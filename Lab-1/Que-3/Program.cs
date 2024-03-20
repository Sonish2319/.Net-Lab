using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10 };

        
        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        
        ReverseArray(numbers);

        
        Console.WriteLine("\nReversed Array:");
        PrintArray(numbers);
    }


    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

           
            start++;
            end--;
        }
    }

    
    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
