using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 4;
            Console.WriteLine("Rectangle Area = " + rectangle.CalculateArea());

            Rectangle square = new Square();
            square.Width = 5;
            square.Height = 4;
            Console.WriteLine("Square Area = " + square.CalculateArea());
        }
    }
}
