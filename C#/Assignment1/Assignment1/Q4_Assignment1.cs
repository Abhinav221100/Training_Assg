using System;


namespace Assignment1
{
    public class SwapNumbers
    {
        public void Swap()
        {
            Console.WriteLine("\n\nThis is Question4 of Assignment1 \n");
            SwapNumbers obj1 = new SwapNumbers();
            Console.WriteLine("Enter the first number below:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number below:");
            int num2 = int.Parse(Console.ReadLine());
            obj1.Swap(ref num1, ref num2);
            Console.WriteLine("The first number is now {0}", num1);
            Console.WriteLine("The second number is now {0}", num2);
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
