using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // string testVerse = ("This is a test sentence for my scripture memorization program. This needs to be able to hide a couple random words \n at a time until the whole sentence is blank or you decide to \"quit\".");

        // // string testVerse2 = ("This is a SECOND test sentence for my scripture memorization program. This needs to be able to hide a couple random words \n at a time until the whole sentence is blank or you decide to \"quit\".");

        // string book = "Nephi";

        // int chapter = 1;

        // int startVerse = 2;

        // int endVerse = 3;

        // // Testing purpose for new reference working (single verse)
        // // Reference Reference = new Reference(book, chapter, startVerse);


        // Reference Reference2 = new Reference(book, chapter, startVerse, endVerse);

        // // string words = testVerse;

        // // Testing purpose for new reference working (single verse)
        // // Scripture scriptureVerse = new Scripture(Reference, testVerse);


        // // Testing purpose for new reference working (multi verse)
        // Scripture scriptureVerse2 = new Scripture(Reference2, testVerse);

        // scriptureVerse2._scriptures.Add(new string(testVerse));
        // // scriptureVerse2._scriptures.Add(new string(testVerse2));

        // scriptureVerse2.WordDisplay();


        // bool multiverseScripture = false;

        Console.WriteLine("Welcome to the Scripture Memorizer Application! Is the scripture you want to memorize have multiple verses?");
        string multiverseScripture = Console.ReadLine();

        if (multiverseScripture.ToLower() == "no")
        {
            Console.WriteLine("What book is the scripture from? ");
            string book = Console.ReadLine();

            Console.WriteLine("What Chapter is the scripture from? ");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("What verse is the scripture? ");
            int startVerse = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the text for scripture {char.ToUpper(book[0]) + book.Substring(1)} {chapter} {startVerse}. ");
            string scriptureText = Console.ReadLine();

            Reference reference = new Reference(book, chapter, startVerse);


            string stringReference = reference.GetSingleReference();

            Scripture scripture = new Scripture(stringReference, scriptureText);
            
        }

        else if (multiverseScripture.ToLower() == "yes")
        {
            Console.WriteLine("What book is the scripture from? ");
            string book = Console.ReadLine();

            Console.WriteLine("What Chapter is the scripture from? ");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the beginning verse of the scripture? ");
            int startVerse = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the end verse of the scripture? ");
            int endVerse = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter the text for scripture {char.ToUpper(book[0])} {chapter} {startVerse}. ");
            string scriptureText = Console.ReadLine();

            Reference reference = new Reference(book, chapter, startVerse, endVerse);

            string stringReference = reference.GetMultiReference();

            Scripture scripture = new Scripture(stringReference, scriptureText);

        }

    }
}