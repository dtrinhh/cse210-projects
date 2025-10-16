using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionTest1 = new Fraction();

        int testNum1 = 6;
        Fraction fractionTest2 = new Fraction(testNum1);

        int testNum2 = 7;
        Fraction fractionTest3 = new Fraction(testNum1, testNum2);

        fractionTest1.SetTop(3);
        Console.WriteLine(fractionTest1.GetTop());

        fractionTest1.SetBottom(4);
        Console.WriteLine(fractionTest1.GetBottom());

        fractionTest1.GetFractionString(testNum1, testNum2);
        // fractionTest1.GetFractionString(fractionTest1.GetTop(), fractionTest1.GetBottom());

        fractionTest1.GetDecimalValue(testNum1, testNum2);
        // fractionTest1.GetDecimalValue(fractionTest1.GetTop(), fractionTest1.GetBottom());
    }
}