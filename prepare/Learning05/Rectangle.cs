using System;

public class Rectangle : Shape
{
    private double _shortSide;

    private double _longSide;

    public Rectangle(string color, double longSide, double shortSide) : base(color)
    {
        _shortSide = shortSide;
        _longSide = longSide;
    }
    public override double GetArea()
    {
        return _shortSide * _longSide;
    }

}