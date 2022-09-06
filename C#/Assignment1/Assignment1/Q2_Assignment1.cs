using System;

namespace Assignment1
{
    public class AvgObtained
    {

        public void FindingMax()
        {
            //program to accept marks from 5 students and get highest among them
            Console.WriteLine("\n\nThis is Question2 of Assignment1 \n");
            int[] avg = new int[5];
            Console.WriteLine("Enter average marks for the first student: ");
            avg[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter average marks for the second student: ");
            avg[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter average marks for the third student: ");
            avg[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter average marks for the fourth student: ");
            avg[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter average marks for the fifth student: ");
            avg[4] = int.Parse(Console.ReadLine());

            int max = avg[0];
            for (int i = 0; i < avg.Length; i++)
            {
                if (max < avg[i])
                {
                    max = avg[i];
                }
            }
            Console.WriteLine("The maximum marks obtained is {0}", max);
        }
    }
}
