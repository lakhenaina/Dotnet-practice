using System;

public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

public class Test3
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                throw new MyCustomException("Age must be 18 or above.");
            }

            Console.WriteLine("Valid age entered.");
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
