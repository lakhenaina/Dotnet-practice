using System;

public abstract class Shape
{
    protected double dim1, dim2;

    public Shape(double d1, double d2)
    {
        dim1 = d1;
        dim2 = d2;
    }

    public abstract double Area();
}

public class Rectangle : Shape
{
    public Rectangle(double w, double h) : base(w, h) { }

    public override double Area()
    {
        return dim1 * dim2;
    }
}

public class Triangle : Shape
{
    public Triangle(double b, double h) : base(b, h) { }

    public override double Area()
    {
        return 0.5 * dim1 * dim2;
    }
}

public class Test5
{
    public static void Main()
    {
        Shape r = new Rectangle(10, 5);
        Shape t = new Triangle(10, 5);

        Console.WriteLine("Rectangle Area: " + r.Area());
        Console.WriteLine("Triangle Area: " + t.Area());

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
