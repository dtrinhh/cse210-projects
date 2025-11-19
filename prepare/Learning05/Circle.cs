using System;

public class Circle : Shape
{
    private double _diameter;

    private double _radius;


    public Circle(string color, double diameter) : base(color)
    {
        _diameter = diameter;
        _radius = diameter / 2;
    }
    public override double GetArea()
    {
        return _radius * 3.14;
    }


}