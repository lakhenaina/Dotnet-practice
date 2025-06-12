using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxValue = Max(numbers);
        Console.WriteLine("Max: " + maxValue);
    }

    static int Max(int[] arr)
    {
        int maxValue = arr[0];
        foreach (int num in arr)
        {
            if (num > maxValue)
                maxValue = num;
        }
        return maxValue;
    }
}