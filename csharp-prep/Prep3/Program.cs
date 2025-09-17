using System;

class Program
// OLD CODE
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep3 World!");
//     }
// }

{
    static void Main(string[] args)
    {
        int guess = 0;
        int magicNum = 1;

        if (guess != magicNum)
        {
            Console.WriteLine("What is the magic number?");
            string setNum = Console.ReadLine();
            magicNum = int.Parse(setNum);


            Console.WriteLine("What is your guess?");
            string filler = Console.ReadLine();
            guess = int.Parse(filler);

        }

        if (guess == magicNum)
        {
            Console.WriteLine("That is correct!");
        }
        else if (guess > magicNum)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");
        }
    }
}