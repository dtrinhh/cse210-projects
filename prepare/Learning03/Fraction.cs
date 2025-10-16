using System;
using System.Numerics;
using System.Runtime.CompilerServices;

class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        int fractionTotal = _top / _bottom;

        Console.WriteLine($"Your total is {fractionTotal} (numerator and denomintor default to 1)");
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
        int fractionTotal = _top / _bottom;

        Console.WriteLine($"Your total is {fractionTotal} (denomintor default to 1)");
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

        double fractionTotal = _top / _bottom;
        Console.WriteLine($"Your total is {fractionTotal} (numerator = {_top} & Denominator = {_bottom})");
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetFractionString(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

        Console.WriteLine($"{_top} / {_bottom}");
    }

    public void GetDecimalValue(int top, int bottom)
    { 
        _top = top;
        _bottom = bottom;

        // Casting one of the int variables to be a double type because it is a requirement. Otherwise just returns the integer portion and no decimals.
        double fractionTotal = _top / (double)_bottom;

        // Displays Total with 2 decimal places (rounded) You can select ho wmany it'll round to by changing the number in .ToString("F#")
        string cleanTotal = fractionTotal.ToString("F2");
        Console.WriteLine($"Your total is {cleanTotal} (numerator = {_top} & Denominator = {_bottom})");


        // Displays Total with ALL decimals
        // Console.WriteLine($"Your total is {fractionTotal} (numerator = {_top} & Denominator = {_bottom})");
    }

}