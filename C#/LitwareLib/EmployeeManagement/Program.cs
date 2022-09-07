// See https://aka.ms/new-console-template for more information
using System;
using LitwareLib;

namespace EmployeeManagement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of employees to be entered :");
            int numOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfEmployees; i++)
            {
                Console.WriteLine("Enter the employee number below :");
                int employeeNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the employee below :");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Enter the salary below :");
                double employeeSalary = double.Parse(Console.ReadLine());
                Employee emp1 = new Employee(employeeNumber, employeeName, employeeSalary);
                emp1.CalculateSalary();
                emp1.DisplayGrossSalary();
            }
        }
    }
}
