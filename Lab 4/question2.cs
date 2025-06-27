using System;

public class Test2
{
    public static void Main()
    {
        try
        {
            int[] numbers = new int[3] { 10, 20, 30 };

            Console.Write("Enter index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value: " + numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index out of range!");
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
