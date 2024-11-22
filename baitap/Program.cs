using System;
using System.Collections.Generic;
using System.Linq;
using baitap;

namespace baitap

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, Name = "Anh", Age = 15 },
                new Student() { Id = 2, Name = "Phong", Age = 17 },
                new Student() { Id = 3, Name = "Duy", Age = 16 },
                new Student() { Id = 4, Name = "Giang", Age = 18 },
                new Student() { Id = 5, Name = "Phuong", Age = 14 }
            };

            Console.WriteLine("a. Danh sach hoc sinh:");
            var allStudents = students.ToList();
            foreach (var student in allStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
            Console.WriteLine("\nb. Hoc sinh tu 15 đen 18 tuoi:");
            var studentsByAge = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentsByAge)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }
            Console.WriteLine("\nc. Hoc sinh co ten bat đau bang 'A':");
            var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }

            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nd. Tong tuoi cua tat ca hoc sinh: {totalAge}");

            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            var oldestStudent = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"ID: {oldestStudent.Id}, Ten: {oldestStudent.Name}, Tuoi: {oldestStudent.Age}");

            Console.WriteLine("\nf. Danh sach hoc sinh theo tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Ten: {student.Name}, Tuoi: {student.Age}");
            }

            Console.ReadKey();
        }
    }
}