using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        string color = "green";

        // TESTING
        // Square square = new Square(color, 0);

        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        // Rectangle rectangle = new Rectangle(color, 4, 2);

        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        // Circle circle = new Circle(color, 5);

        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();

        Square square = new Square(color, 0);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle(color, 4, 2);
        shapes.Add(rectangle);
        Circle circle = new Circle(color, 5);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}