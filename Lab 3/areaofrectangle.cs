using System;

public class Area
{
    private double length;
    private double breadth;

    public Area(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public double GetArea()
    {
        return length * breadth;
    }
}

public class Test3
{
    public static void Main()
    {
        Console.Write("Enter Length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Breadth: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        Area rect = new Area(length, breadth);
        Console.WriteLine("Area of Rectangle: " + rect.GetArea());

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
