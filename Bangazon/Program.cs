using System;
//using System.Globalization;
using System.Collections.Generic;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            var dave = new Employee("Dave", "Administrator");
            var jessica = new Employee("Jessica", "Manager");
            var colin = new Employee("Colin", "CEO");

            var myCompany = new Company("My Company");

            myCompany.AddEmployee(dave);
            myCompany.AddEmployee(jessica);
            myCompany.AddEmployee(colin);

            Console.WriteLine("Hello World!");

            myCompany.ListEmployee();
            Console.ReadKey();
        }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        private List<Employee> CurrentEmployees = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee employee)
        {
            CurrentEmployees.Add(employee);
        }
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee employee)
        {
            CurrentEmployees.Remove(employee);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
        }

        public void ListEmployee()
        {
            foreach (var employee in CurrentEmployees) {
                Console.WriteLine($"Employee Name: {employee.EmployeeName}");
            }
        }
    }

    public class Employee
    {
        public string EmployeeName { get; private set; }
        public string JobTitle { get; private set; }
        public string DateAdded { get; private set; }

        public Employee(string employeeName, string jobTitle)
        {
            EmployeeName = employeeName;
            JobTitle = jobTitle;
            DateAdded = DateTime.Now.ToString("en-US");
        }
    }
}
