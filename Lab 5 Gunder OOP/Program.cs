using System;

namespace Lab_5_Gunder_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();

            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();

            Console.WriteLine("Circle with Radius 5 has an area of: " + area1);
            Console.WriteLine("Circle with Radius 6 has an area of: " + area2);
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