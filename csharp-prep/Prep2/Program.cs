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
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            Console.WriteLine($"That's an {letter}, you passed the class!");
        }
        else
        {
            Console.WriteLine($" That's an {letter}, sorry you did not pass the class, better luck next time! ");
        }
    }
}