// See https://aka.ms/new-console-template for more information
using System;
using LitwareLib;

namespace EmployeeManagement
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee(677, "Mark", 58000);
            emp1.CalculateSalary();
            emp1.DisplayGrossSalary();
        }
    }
}
