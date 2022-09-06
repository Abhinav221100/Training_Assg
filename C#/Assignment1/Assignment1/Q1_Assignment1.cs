using System;

namespace Assignment1
{
    public class Calculator
    {
        public void Calculate()
        {
            //program to create calculator that does basic arithmetic operations.
            Console.WriteLine("This is Question1 of Assignment1\n\n");
            Console.WriteLine("Enter the first number below:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number below:");
            int num2 = int.Parse(Console.ReadLine());
            int op = 0;
            do
            {
                Console.WriteLine("Enter a number corresponding to the operation required :\n" +
                                  "1.   Addition\n" +
                                  "2.   Subtraction\n" +
                                  "3.   Multiplication\n" +
                                  "4.   Division");
                op = int.Parse(Console.ReadLine());
                //Console.WriteLine("------------- {0}", op);
                if (op != 1 && op != 2 && op != 3 && op != 4)
                {
                    Console.WriteLine("Select a valid operation.");
                }
            } while (op != 1 && op != 2 && op != 3 && op != 4);

            //int result;
            //entering switch case for diff operations.
            switch (op)
            {
                case 1:
                    int sum = num1 + num2;
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
                    break;
                case 2:
                    int diff = num1 - num2;
                    Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, diff);
                    break;
                case 3:
                    int prod = num1 * num2;
                    Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, prod);
                    break;
                case 4:
                    int quotient = num1 / num2;
                    Console.WriteLine("The quotient of {0} and {1} is {2}", num1, num2, quotient);
                    break;
            }

        }
    }
}