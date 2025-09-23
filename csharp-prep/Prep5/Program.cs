using System;
using System.Data;
using System.Security.Cryptography;

class Program
// OLD CODE
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep5 World!");
//     }
// }


{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();

        int number = PromptUserNumber();

        int year = 0;
        PromptUserBirthYear(out year);

        DisplayResult(username, number, year);
        
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        // int number = 0;
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("What is your birth year? ");
        year = int.Parse(Console.ReadLine());    
    }

    static int SquareNumber(int number)
    {
        int squaredNum = number * number;
        return squaredNum;
    }

    static void DisplayResult(string username, int number, int birthYear)
    {
        string name = username;
        Console.WriteLine($"Name: {name}.");

        int squaredNum = SquareNumber(number);
        Console.WriteLine($"{name}, your number squared: {squaredNum}");        

        int YearOfBirth = birthYear;
        int currentYear = DateTime.Now.Year;
        int age = currentYear - YearOfBirth;
        Console.WriteLine($"{name}, you should be {age} this year.");
    }
    
    }
}


