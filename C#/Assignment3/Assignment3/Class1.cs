using System.Text.RegularExpressions;

namespace Assignment3
{
    interface ICloneable
    {
        public int[] clone(int size, int[] stack);
    }

    public class MyStack : ICloneable
    {
        public int[] stack;
        public int top;
        int size;

        public MyStack(int size)
        {
            this.top =  -1;
            this.size = size;
            this.stack = new int[size]; 
        }

        public void push(int data)
        {
            if(top+1>=size)
            { 
                Console.WriteLine("----------");
                Console.WriteLine("WARNING : Buffer Overflow");
                Console.WriteLine("----------");
                return;
            }
            top = top + 1;
            stack[top] = data;
            Console.WriteLine("----------");
            Console.WriteLine("Push operation successfull");
            Console.WriteLine("----------");
        }

        public int pop()
        {
            if(top == -1)
            {
                Console.WriteLine("----------");
                Console.WriteLine("WARNING : Buffer Underflow");
                Console.WriteLine("----------");
                return -99999;
            }
            int value = stack[top];
            top = top - 1;
            Console.WriteLine("----------");
            Console.WriteLine("Pop operation successfull");
            Console.WriteLine("----------");
            return value;
        }

        public int[] clone(int size, int[] stack)
        {
            MyStack stack2 = new MyStack(size);
            stack2.stack = stack;
            Console.WriteLine("----------");
            Console.WriteLine("Cloning operation successfull");
            Console.WriteLine("----------");
            return stack2.stack;
        }
    }
}