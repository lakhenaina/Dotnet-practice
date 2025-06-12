// WAP to print all prime numbers 100 to 200.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Prime numbers between 100 and 200:");

        for (int num = 100; num <= 200; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= n / 2; i++) // Check divisibility
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
