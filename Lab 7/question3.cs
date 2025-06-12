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
            // List of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ram", Age = 15, Address = "Kathmandu" },
                new Student { Name = "Sita", Age = 12, Address = "Pokhara" },
                new Student { Name = "Hari", Age = 17, Address = "Lalitpur" },
                new Student { Name = "Gita", Age = 20, Address = "Bhaktapur" },
                new Student { Name = "Mina", Age = 16, Address = "Dharan" }
            };

            // Using LINQ to filter teenagers (age 13 to 19)
            var teenagers = from student in students
                            where student.Age >= 13 && student.Age <= 19
                            select student;

            Console.WriteLine("Teenage Students:");
            foreach (var student in teenagers)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Address: {2}", student.Name, student.Age, student.Address);
            }
        }
    }
}
