using System;

namespace ShapeAreas
{
    // Abstract class Shape
    abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement the GetArea() method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implement the GetArea() method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle
            Circle circle = new Circle(5);
            Console.WriteLine($"The area of the circle is: {circle.GetArea()}");

            // Create an instance of Rectangle
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea()}");
        }
    }
}
