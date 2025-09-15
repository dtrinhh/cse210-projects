using System;
using System.Runtime.CompilerServices;

// OLD CODE
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep2 World!");
//     }
// }

// Prep 2 assignment
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade percentage did you receive?");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        if (grade >= 90)
        {
            Console.WriteLine("That's an A.");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("That's a B.");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("That's a C.");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("That's a D.");
        }
        else
        {
            Console.WriteLine("That's an F.");
        }

        if (grade > 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass the class, better luck next time! ");
        }
    }
}