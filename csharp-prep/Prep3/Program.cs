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
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(1, 11);
        int guess = 0;
        int attempts = 0;

        while (guess != randomNum)
        {
            Console.WriteLine("What is your guess?");
            string filler = Console.ReadLine();
            guess = int.Parse(filler);

            attempts++;

            if (guess == randomNum)
            {
                Console.WriteLine($"That is correct, it took you {attempts} guesses!");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine($"Lower, you are on guess number {attempts}");
            }
            else
            {
                Console.WriteLine($"Higher, you are on guess number {attempts}");
            }
        }
    }
}