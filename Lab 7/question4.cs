using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ram", Age = 15, Address = "Kathmandu" },
                new Student { Name = "Sita", Age = 12, Address = "Pokhara" },
                new Student { Name = "Ram", Age = 20, Address = "Lalitpur" },
                new Student { Name = "Gita", Age = 20, Address = "Bhaktapur" },
                new Student { Name = "Mina", Age = 16, Address = "Dharan" }
            };

            // Find first student with name "Ram"
            Student firstRam = students.FirstOrDefault(s => s.Name == "Ram");

            if (firstRam != null)
            {
                Console.WriteLine("First student named Ram:");
                Console.WriteLine("Name: {0}, Age: {1}, Address: {2}", firstRam.Name, firstRam.Age, firstRam.Address);
            }
            else
            {
                Console.WriteLine("No student named Ram found.");
            }
        }
    }
}
