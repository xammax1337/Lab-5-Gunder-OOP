using System;

namespace Lab_5_Gunder_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);

            Circle circle2 = new Circle(6);

            Console.WriteLine("Circle1 with Radius 5 has an area of: " + circle1.GetArea());
            Console.WriteLine("Circle2 with Radius 6 has an area of: " + circle2.GetArea());
        }
    }

    class Circle
    {
        private int radius;
        private const double pi = Math.PI;

        public Circle(int radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return radius * radius * pi;
        }
    }
}