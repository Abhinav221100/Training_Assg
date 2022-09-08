// See https://aka.ms/new-console-template for more information
using System;
using Assignment3;

namespace Console_Assg3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the stack below :");
            int sizeOfStack = int.Parse(Console.ReadLine());
            MyStack stack1 = new MyStack(sizeOfStack);
            int choice;

            do
            {
                do
                {
                    Console.WriteLine("Choose one of the Operations from below (Choose a number) :\n" +
                                      "1. Push\n" +
                                      "2. Pop\n" +
                                      "3. Clone\n" +
                                      "4. Quit\n");
                    choice = int.Parse(Console.ReadLine());
                    if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
                    {
                        Console.WriteLine("Enter a Valid option.");
                    }
                    if (choice == 4)
                    {
                        break;
                    }

                } while (choice != 1 && choice != 2 && choice != 3);

                if (choice == 4)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a number to push onto stack :");
                        int data = int.Parse(Console.ReadLine());
                        stack1.push(data);
                        break;
                    case 2:
                        int value = stack1.pop();
                        //if(value == -99999)
                        //{
                        //    break;
                        //}
                        Console.WriteLine("The value popped is {0}\n", value);
                        break;
                    case 3:
                        int[] clone = stack1.clone(sizeOfStack, stack1.stack);
                        int temp = stack1.top;
                        Console.WriteLine("----------");
                        Console.WriteLine("The Cloned Stack is as follows :");
                        while (temp > -1)
                        {
                            Console.WriteLine(clone[temp]);
                            temp = temp - 1;
                        }
                        Console.WriteLine("----------");
                        break;
                    case 4:
                        break;
                }
            } while (choice == 1 || choice == 2 || choice == 3);


        }

    }
}
