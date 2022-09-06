// See https://aka.ms/new-console-template for more information
using System;
using Assignment1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //------Q1_Assignment1---------
            Calculator obj1 = new Calculator();
            obj1.Calculate();

            //------Q2_Assignment1---------
            AvgObtained obj2 = new AvgObtained();
            obj2.FindingMax();

            //------Q3_Assignment1---------
            ParamArrayOfIntegers obj3 = new ParamArrayOfIntegers();
            obj3.FindSum();

            //------Q4_Assignment1---------
            SwapNumbers obj4 = new SwapNumbers();
            obj4.Swap();

            //------Q5_Assignment1---------
            Circle obj5 = new Circle();
            obj5.FindAreaAndCircumference();

            //------Q6_Assignment1---------
            App obj6 = new App();
            obj6.Console();
        }
    }
}
