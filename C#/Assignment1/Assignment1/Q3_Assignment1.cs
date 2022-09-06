using System;


namespace Assignment1
{
    public class ParamArrayOfIntegers
    {
        public void FindSum()
        {
            Console.WriteLine("\n\nThis is Question3 of Assignment1 \n");
            int result;
            result = SupplyIntegers(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("The sum of the integers passed = {0}", result);
        }

        static int SupplyIntegers(params int[] values)
        {   //static method that accept param array of integers and returns their sum.
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum = sum + values[i];
            }
            return sum;
        }
    }
}
