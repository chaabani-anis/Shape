using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle {Width = 5, Height = 4};
            Console.WriteLine("Rectangle Area = " + rectangle.CalculateArea());

            Rectangle square = new Square { Width = 5, Height = 4 };
            Console.WriteLine("Square Area = " + square.CalculateArea());

            Console.Read();
        }
    }
}
