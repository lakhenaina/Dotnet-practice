// WAP to find factorial of a number.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i; // Multiply each number from 1 to n
        }

        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }
}
