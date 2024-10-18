using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter information for student {i + 1}:");
            Student student = new Student();
            student.Input();
            students.Add(student);
        }

        Console.WriteLine("\nList of students:");
        foreach (var student in students)
        {
            student.Display();
            Console.WriteLine();
        }

        Console.WriteLine("Searching for student named 'Nam':");
        foreach (var student in students)
        {
            if (student.Name == "Nam")
            {
                student.Display();
                Console.WriteLine();
            }
        }
    }
}
