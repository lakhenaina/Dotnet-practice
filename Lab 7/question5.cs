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
                new Student { Name = "Hari", Age = 17, Address = "Lalitpur" },
                new Student { Name = "Gita", Age = 20, Address = "Bhaktapur" },
                new Student { Name = "Mina", Age = 16, Address = "Dharan" }
            };

            // Sort students by age ascending using LINQ
            var sortedStudents = students.OrderBy(s => s.Age);

            Console.WriteLine("Students sorted by age:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Address: {2}", student.Name, student.Age, student.Address);
            }
        }
    }
}
