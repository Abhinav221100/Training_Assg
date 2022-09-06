using System;


namespace Assignment1
{
    public class Circle
    {
        static float pi = 3.14F;
        public void FindAreaAndCircumference()
        {
            Console.WriteLine("\n\nThis is Question5 of Assignment1\n");
            Circle c = new Circle();
            Console.WriteLine("Enter the radius below :");
            int radius = int.Parse(Console.ReadLine());
            float area;
            float circumference;
            c.CalculateAreaAndCircumference(Circle.pi, radius, out area, out circumference);
            Console.WriteLine("The area and circumference of a circle with radius {0} are {1} and {2} respectively.", radius, area, circumference);
        }

        public void CalculateAreaAndCircumference(float pi, int radius, out float area, out float circumference)
        {
            area = pi * radius * radius;
            circumference = 2 * pi * radius;
        }
    }

}
