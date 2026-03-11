using System;
using System.Collections.Generic;

class H1_set_interface
{
    List<string> employees;

    // Employee collection 
    void EmployeeObjects()
    {
        employees = new List<string>();
        employees.Add("Rahul");
        employees.Add("Anjali");
        employees.Add("Amit");
        employees.Add("Sakshi");
    }

    // Employee search function
    void FindEmployee()
    {
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine();

        if (employees.Contains(searchName))
        {
            Console.WriteLine("Employee found: " + searchName);
        }
        else
        {
            Console.WriteLine("Employee " + searchName + " does not exist.");
        }
    }

    public static void Main(string[] args)
    {
        H1_set_interface ob = new H1_set_interface();
        ob.EmployeeObjects();
        ob.FindEmployee();
    }
}