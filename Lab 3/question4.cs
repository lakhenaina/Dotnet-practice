using System;

public class Person
{
    protected string name;
    protected int age;

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

public class Student : Person
{
    private string faculty;

    public Student(string n, int a, string f) : base(n, a)
    {
        faculty = f;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Faculty: " + faculty);
    }
}

public class Teacher : Person
{
    private double salary;

    public Teacher(string n, int a, double s) : base(n, a)
    {
        salary = s;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Salary: " + salary);
    }
}

public class Test4
{
    public static void Main()
    {
        Student s = new Student("Priya", 20, "Computer Science");
        Teacher t = new Teacher("Dr. Sharma", 45, 80000);

        Console.WriteLine("Student Info:");
        s.ShowInfo();

        Console.WriteLine("\nTeacher Info:");
        t.ShowInfo();

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
