using System;

namespace LitwareLib
{
    //cerating an interface to print all detail of an employee
    interface IPrintable
    {
        void PrintDetailsOfEmployee();

    }
    public class Employee : IPrintable
    {
        private int EmpNo;
        private string EmpName;
        private double salary;
        public double HRA, TA, DA, PF, TDS;
        public double NetSalary;
        public double GrossSalary;

        //defining the properties of private members
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

        //parametrized constructor
        public Employee(int EmpNo, string EmpName, double salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            Salary = salary;
        }

        //func to calculate the gross salary and net salary
        public virtual void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = 0.1 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.1 * Salary;
                DA = 0.2 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.2 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.2 * Salary;
                DA = 0.3 * Salary;
            }
            else
            {
                HRA = 0.3 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }

            GrossSalary = Salary + HRA + TA + DA;
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }

        //func to display gross salary
        public void DisplayGrossSalary()
        {
            Console.WriteLine("The Gross Salary is {0}", GrossSalary);
        }

        //defining the method of the interface
        public void PrintDetailsOfEmployee()
        {
            Console.WriteLine("Name of Employee : {0}", EmpName);
            Console.WriteLine("Employee Number of Employee : {0}", EmpNo);
            Console.WriteLine("Base Salary of Employee : {0}", Salary);
            Console.WriteLine("Gross Salary of Employee : {0}", GrossSalary);
            Console.WriteLine("Net Salary of Employee : {0}", NetSalary);
        }

    }

    public class Manager : Employee
    {
        private double _petrolAllowance;
        private double _foodAllowance;
        private double _otherAllowance;

        //parametrized constructor
        public Manager(int EmpNo, string EmpName, double salary) : base(EmpNo, EmpName, salary)
        {

        }

        //overriding calculate salary method from base class
        public override void CalculateSalary()
        {
            base.CalculateSalary();

            _petrolAllowance = 0.08 * Salary;
            _foodAllowance = 0.13 * Salary;
            _otherAllowance = 0.03 * Salary;

            PF = 0.1 * GrossSalary;
            //TDS = 0.18 * GrossSalary;
            GrossSalary = GrossSalary + _petrolAllowance + _foodAllowance + _otherAllowance;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }
    }

    public class MarketingExecutive : Employee
    {
        private double _kilometeresTravelled;
        private double _tourAllowance;
        private int _telephoneAllowance = 1000;

        //parametrized constructor
        public MarketingExecutive(int EmpNo, string EmpName, double salary, double kilometeresTravelled) : base(EmpNo, EmpName, salary)
        {
            this._kilometeresTravelled = kilometeresTravelled;
        }

        //overriding func from base class
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            _tourAllowance = 5 * _kilometeresTravelled;
            PF = 0.1 * GrossSalary;
            //TDS = 0.18 * GrossSalary;
            GrossSalary = GrossSalary + _telephoneAllowance + _tourAllowance;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }


    }
}