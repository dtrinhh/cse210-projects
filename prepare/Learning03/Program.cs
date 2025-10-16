using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionTest1 = new Fraction();

        int testNum1 = 6;
        Fraction fractionTest2 = new Fraction(testNum1);

        int testNum2 = 7;
        Fraction fractionTest3 = new Fraction(testNum1, testNum2);

    }
}