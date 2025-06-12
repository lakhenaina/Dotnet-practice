using System;


class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int reversedNumber = Reverse(n);
        Console.WriteLine("Reversed: " + reversedNumber);
    }

    static int Reverse(int n)
    {
        int reversed = 0;
        while (n > 0)
        {
            reversed = reversed * 10 + n % 10;
            n /= 10;
        }
        return reversed;
    }
}