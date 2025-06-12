using System;

public class Number
{
    public int value;

    public Number(int v)
    {
        value = v;
    }

    public static Number operator --(Number n)
    {
        n.value = n.value - 1;
        return n;
    }

    public void Display()
    {
        Console.WriteLine("Value: " + value);
    }
}

public class Test5
{
    public static void Main()
    {
        Number num = new Number(10);
        Console.WriteLine("Original:");
        num.Display();

        --num;

        Console.WriteLine("After -- operator:");
        num.Display();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
