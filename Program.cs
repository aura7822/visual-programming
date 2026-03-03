using System;

public class Employee
{
    public int id;
    public string name;
    public float salary;

    public Employee(int i, string n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }

    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}

class TestEmployee
{
    public static void Main(string[] args)
    {
        // Employee 1
        Console.WriteLine("Enter details for Employee 1:");

        Console.Write("Enter ID: ");
        int id1;
        while (!int.TryParse(Console.ReadLine(), out id1))
        {
            Console.Write("Invalid ID. Please enter a valid number: ");
        }

        Console.Write("Enter Name: ");
        string? name1 = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(name1))
        {
            Console.Write("Name cannot be empty. Please enter a name: ");
            name1 = Console.ReadLine();
        }

        Console.Write("Enter Salary: ");
        float salary1;
        while (!float.TryParse(Console.ReadLine(), out salary1))
        {
            Console.Write("Invalid salary. Please enter a valid number: ");
        }

        // Employee 2
        Console.WriteLine("\nEnter details for Employee 2:");

        Console.Write("Enter ID: ");
        int id2;
        while (!int.TryParse(Console.ReadLine(), out id2))
        {
            Console.Write("Invalid ID. Please enter a valid number: ");
        }

        Console.Write("Enter Name: ");
        string? name2 = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(name2))
        {
            Console.Write("Name cannot be empty. Please enter a name: ");
            name2 = Console.ReadLine();
        }

        Console.Write("Enter Salary: ");
        float salary2;
        while (!float.TryParse(Console.ReadLine(), out salary2))
        {
            Console.Write("Invalid salary. Please enter a valid number: ");
        }

        Employee e1 = new Employee(id1, name1, salary1);
        Employee e2 = new Employee(id2, name2, salary2);

        Console.WriteLine("\nEmployee Details:");
        e1.display();
        e2.display();

        Console.ReadLine();
    }
}