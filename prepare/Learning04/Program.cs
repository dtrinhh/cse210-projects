using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Dustin Trinh";
        string topic = "Addition";
        string textbookSelection = "Mathematics Vol 1";
        string problems = "1-10";
        string title = "Math for Dummies";


        Assignment assignment1 = new Assignment(name, topic);
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment(name, topic, textbookSelection, problems);
        Console.Write(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment(name, topic, title);
        Console.Write(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}