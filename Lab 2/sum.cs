using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0;

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine("Sum: " + sum);
    }
}
