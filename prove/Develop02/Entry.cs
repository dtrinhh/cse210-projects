using System;

public class Entry()
{
    public string _entryText;

    public string _dateText;
    
    public string _entryPrompt;
    

    public void DisplayEntries()
    {
        Console.WriteLine($"Date: {_dateText} - Prompt: {_entryPrompt}");
        Console.WriteLine($"{_entryText}");
    }
}