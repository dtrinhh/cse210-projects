using System;
using System.Collections.Specialized;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string stop = "-1";
        int discontinue = int.Parse(stop);

        Journal journal = new Journal();

        while (discontinue != 5)
        {
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Write new journal entry ");
            Console.WriteLine("2. Display journal entry ");
            Console.WriteLine("3. Save journal entry ");
            Console.WriteLine("4. Load journal entry ");
            Console.WriteLine("5. Quit program ");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum == 1)
            {
                // Cretes new PromptGenerator instance named prompt and it'll "randomly" pull a prompt from its list. 
                PromptGenerator prompt = new PromptGenerator();
                prompt.GetPrompt();

                string promptResponse = Console.ReadLine();
                journal._entryResponse = promptResponse;

                // Attaching the given prompt to a variable for Journal to save a txt file
                journal._writeEntry = prompt._listPrompt[prompt._randomIndexNum];

                // Gives the date in a string format
                DateTime currentDay = DateTime.Now;
                journal._entryDate = currentDay.ToShortDateString();

                // Gives values to store in Entry class. 
                journal._listEntries.Add(new Entry { _dateText = journal._entryDate, _entryPrompt = journal._writeEntry, _entryText = journal._entryResponse });

            }

            else if (userNum == 2)
            {
                journal.Display();
            }

            else if (userNum == 3)
            {
                Console.WriteLine("What did you want to name the file?");
                string nameChoice = Console.ReadLine();
                string fileName = $"{nameChoice}.txt";


                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry journalEntry in journal._listEntries)
                    {
                        outputFile.WriteLine($"Date: {journal._entryDate}~~{journal._writeEntry}~~{journal._entryResponse}");
                    }
                }
                Console.WriteLine("Your file has been saved! ");
            }

            else if (userNum == 4)
            {
                Console.WriteLine("What file did you want to load? ");
                string nameChoice = Console.ReadLine();
                string fileName = $"{nameChoice}.txt";

                Console.WriteLine("Reading list from file! ");

                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("~~");
                    journal._entryDate = parts[0];
                    journal._writeEntry = parts[1];
                    journal._entryResponse = parts[2];
                }

            }

            else if (userNum == 5)
            {
                discontinue = 5;
            }
        }
    }
}