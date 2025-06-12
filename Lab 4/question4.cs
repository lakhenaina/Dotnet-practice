using System;

public class Time
{
    public int hr, min, sec;

    public Time(int h, int m, int s)
    {
        hr = h;
        min = m;
        sec = s;
    }

    public static Time operator +(Time t1, Time t2)
    {
        int totalSec = t1.sec + t2.sec;
        int totalMin = t1.min + t2.min + totalSec / 60;
        int totalHr = t1.hr + t2.hr + totalMin / 60;

        return new Time(totalHr, totalMin % 60, totalSec % 60);
    }

    public void Display()
    {
        Console.WriteLine("Time: {0} hr {1} min {2} sec", hr, min, sec);
    }
}

public class Test4
{
    public static void Main()
    {
        Time t1 = new Time(1, 45, 50);
        Time t2 = new Time(2, 30, 20);

        Time sum = t1 + t2;

        Console.WriteLine("First Time:");
        t1.Display();

        Console.WriteLine("Second Time:");
        t2.Display();

        Console.WriteLine("Sum of Times:");
        sum.Display();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
