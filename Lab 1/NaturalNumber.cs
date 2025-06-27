// WAP to find sum of first N natural numbers.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (N): ");
        int n = int.Parse(Console.ReadLine());

        int sum = (n * (n + 1)) / 2; // Formula for sum of first N natural numbers

        Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);
    }
}
