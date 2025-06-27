using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter size of square matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Diagonal elements:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(matrix[i, i]);
        }
    }
}