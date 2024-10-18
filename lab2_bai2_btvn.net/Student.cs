using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_bai2_btvn.net;

public class Student : Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string NativePlace { get; set; }
    public string Id { get; set; }

    public Student() { }

    public Student(string name, int age, string nativePlace, string id)
    {
        Name = name;
        Age = age;
        NativePlace = nativePlace;
        Id = id;
    }

    public void Input()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Age: ");
        Age = int.Parse(Console.ReadLine());
        Console.Write("Enter Native Place: ");
        NativePlace = Console.ReadLine();
        Console.Write("Enter ID: ");
        Id = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Native Place: {NativePlace}");
        Console.WriteLine($"ID: {Id}");
    }
}

