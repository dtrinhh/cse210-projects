using System;

class Program
{
    static void Main(string[] args)
    {

        string color = "green";


        Square square = new Square(color, 0);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(color, 4, 2);

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        
        Circle circle = new Circle(color, 5);

        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());


    }
}