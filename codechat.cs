using System;

class Program
{
    const int MAX = 100;

    static void Main()
    {
        try
        {
            int n = GetNumberOfElements();
            int[] arr = GetArrayInput(n);
            int total = CalculateSum(arr);

            Console.WriteLine("Sum of the numbers: " + total);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Method to get the number of elements
    static int GetNumberOfElements()
    {
        Console.Write("Enter the number of elements (1-100): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1 || n > MAX)
        {
            throw new ArgumentException("Invalid input. Please provide a digit ranging from 1 to 100.");
        }
        return n;
    }

    // Method to get array input from the user
    static int[] GetArrayInput(int n)
    {
        int[] arr = new int[n];
        Console.WriteLine("Enter " + n + " integers:");
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                throw new ArgumentException("Invalid input. Please enter valid integers.");
            }
        }
        return arr;
    }

    // Method to calculate the sum of an array
    static int CalculateSum(int[] arr)
    {
        int result = 0;
        foreach (var num in arr)
        {
            result += num;
        }
        return result;
    }
}