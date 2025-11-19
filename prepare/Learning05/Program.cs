using System;

class Program
{
    static void Main(string[] args)
    {

        string color = "green";


        Square square = new Square(color, 0);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());



    }
}