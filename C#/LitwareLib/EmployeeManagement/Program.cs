// See https://aka.ms/new-console-template for more information
using System;
using LitwareLib;

namespace EmployeeManagement
{
    class Program
    {
        static void Main()
        {
            int option;
            //Interactive loop to choose what type of employee is to be added by user
            do
            {
                Console.WriteLine("What type of Employee would you like to add?\nSelect a number from below :\n" +
                                  "1. Employee\n" +
                                  "2. Manager\n" +
                                  "3. MarketingExecutive\n");
                option = int.Parse(Console.ReadLine());
                //validation
                if (option != 1 && option != 2 && option != 3)
                {
                    Console.WriteLine("Enter a Valid option.\n");
                }
            } while (option != 1 && option != 2 && option != 3);
            switch (option)
            {
                case 1:
                    //case for entering employee data
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
                        Console.WriteLine("----------");
                        emp1.DisplayGrossSalary();
                        Console.WriteLine("----------");
                        emp1.PrintDetailsOfEmployee();
                    }
                    break;
                case 2:
                    //case to add manager data
                    Console.WriteLine("Enter the number of Managers to be entered :");
                    int numOfManagers = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numOfManagers; i++)
                    {
                        Console.WriteLine("Enter the Manager's employee number below :");
                        int employeeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the name of the Manager below :");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter the salary below :");
                        double employeeSalary = double.Parse(Console.ReadLine());
                        Manager manager1 = new Manager(employeeNumber, employeeName, employeeSalary);
                        manager1.CalculateSalary();
                        Console.WriteLine("----------");
                        manager1.DisplayGrossSalary();
                        Console.WriteLine("----------");
                        manager1.PrintDetailsOfEmployee();

                    }
                    break;
                case 3:
                    //case to add marketing exec data
                    Console.WriteLine("Enter the number of Marketing Executive to be entered :");
                    int numOfExecutives = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numOfExecutives; i++)
                    {
                        Console.WriteLine("Enter the Marketing Executive's employee number below :");
                        int employeeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the name of the Marketing Executive below :");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter the salary below :");
                        double employeeSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the kilometers travelled below :");
                        double kilometersTravelled = double.Parse(Console.ReadLine());
                        MarketingExecutive manager1 = new MarketingExecutive(employeeNumber, employeeName, employeeSalary, kilometersTravelled);
                        manager1.CalculateSalary();
                        Console.WriteLine("----------");
                        manager1.DisplayGrossSalary();
                        Console.WriteLine("----------");
                        manager1.PrintDetailsOfEmployee();

                    }
                    break;

            }
        }
    }
}
