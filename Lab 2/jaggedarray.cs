using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter size of row " + (i + 1) + ": ");
            int size = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[size];

            Console.WriteLine("Enter elements of row " + (i + 1) + ":");
            for (int j = 0; j < size; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        int totalSum = 0;
        foreach (var row in jaggedArray)
        {
            foreach (var element in row)
            {
                totalSum += element;
            }
        }

        Console.WriteLine("Sum of jagged array elements: " + totalSum);
    }
}