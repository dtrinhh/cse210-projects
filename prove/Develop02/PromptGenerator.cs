using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

public class PromptGenerator
{
    public List<string> _listPrompt = new List<string>
    {   "What made you smile today? ",
        "What was the funniest joke you heard today? ",
        "What is something you did today that made you proud? ",
        "Who was the most interesting person you interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What is something that happened today that you'd like to do better on next time? ",
        "What was your favorite meal today? "
    };

    public int _randomIndexNum;

    public void GetPrompt()
    {
        Random randomNum = new Random();
        _randomIndexNum = randomNum.Next(1, _listPrompt.Count);

        Console.Write($"{_randomIndexNum}. ");
        Console.WriteLine(_listPrompt[_randomIndexNum]);
    }
}