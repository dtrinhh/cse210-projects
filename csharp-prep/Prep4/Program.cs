using System;
using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program

// OLD CODE
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep4 World!");
//     }
// }

{
    static void Main(string[] args)
    {
        string stop = "-1";
        int discontinue = int.Parse(stop);

        // Creating new list to contain user numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Give me a series of numbers, enter 0 when you are done.");

        while (discontinue != 0)
        {
            // Get numbers from user
            Console.Write("Enter number: ");
            int userNum = int.Parse(Console.ReadLine());

            int sum = 0;
            float average = 0;
            int largestNum = 0;
            int sortedList = 0;

            // Showing list after user is done giving numbers
            if (userNum == 0)
            {
                discontinue = 0;

                // Display list of numbers
                // Console.WriteLine($"Here are the numbers you provided:");

                // for (int i = 0; i < numbers.Count; i++)
                // {
                //     Console.WriteLine($"{numbers[i]}");
                // }

                // Logic for SUM/TOTAL
                for (int x = 0; x < numbers.Count; x++)
                {
                    sum += numbers[x];
                }
                Console.WriteLine($"The sum is {sum}");

                // Logic for AVERAGE
                average = ((float)sum) / numbers.Count;
                Console.WriteLine($"The average is {average}");

                // Logic for LARGEST NUMBER
                largestNum = numbers.Max();
                Console.WriteLine($"This the largest number is {largestNum}");

                // Logic for SORTING LIST from lowest to highest
                numbers.Sort();

                Console.WriteLine("Here is the sorted list: ");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }

            // Adding users numbers to list
            numbers.Add(userNum);
        }
    }
}