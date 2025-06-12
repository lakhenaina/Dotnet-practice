using System;

public class Employee
{
    private string name;
    private int age;
    private double salary;

    public string GetName() { return name; }
    public void SetName(string value) { name = value; }

    public int GetAge() { return age; }
    public void SetAge(int value) { age = value; }

    public double GetSalary() { return salary; }
    public void SetSalary(double value) { salary = value; }
}

public class Test2
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.SetName("Rahul");
        emp.SetAge(30);
        emp.SetSalary(45000);

        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Age: " + emp.GetAge());
        Console.WriteLine("Salary: " + emp.GetSalary());

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
