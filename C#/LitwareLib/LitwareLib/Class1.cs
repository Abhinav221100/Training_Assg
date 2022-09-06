using System;

namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double salary;
        double HRA, TA, DA, PF, TDS;
        double NetSalary;
        double GrossSalary;

        public int empNo
        {
            get;
            set;
        }
        public string empName
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }
        public Employee(int EmpNo, string EmpName, double salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;
        }

        public void CalculateSalary()
        {
            if (salary < 5000)
            {
                HRA = 0.1 * salary;
                TA = 0.05 * salary;
                DA = 0.15 * salary;
            }
            else if (salary < 10000)
            {
                HRA = 0.15 * salary;
                TA = 0.1 * salary;
                DA = 0.2 * salary;
            }
            else if (salary < 15000)
            {
                HRA = 0.2 * salary;
                TA = 0.15 * salary;
                DA = 0.25 * salary;
            }
            else if (salary < 20000)
            {
                HRA = 0.25 * salary;
                TA = 0.2 * salary;
                DA = 0.3 * salary;
            }
            else
            {
                HRA = 0.3 * salary;
                TA = 0.25 * salary;
                DA = 0.35 * salary;
            }

            GrossSalary = salary + HRA + TA + DA;
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public void DisplayGrossSalary()
        {
            Console.WriteLine("The Gross Salary is {0}", GrossSalary);
        }

    }
}