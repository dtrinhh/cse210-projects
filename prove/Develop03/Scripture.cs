using System;
using System.Dynamic;

public class Scripture
{
    private bool _isHidden;

    public bool _isAllHidden;

    // public Reference _reference;
    public string _reference;


    // public List<string> _words = new List<string>();
    public List<string> _scriptures = new List<string>
    {
        
    };
    

    public void WordDisplay()
    {
        foreach (string words in _scriptures)
        {
            Console.WriteLine(words);
        }
    }

    public Scripture()
    {

    }

    public Scripture(string reference, string text)
    {
        _reference = reference;

        _scriptures.Add(text);

        Console.Write($"{_reference} ");
        WordDisplay();
    
    }
    public Scripture(string reference, string text, string text2)
    {
        _reference = reference;

        _scriptures.Add(text);

        _scriptures.Add(text2);

        Console.Write($"{_reference} ");
        WordDisplay();
    
    }

    // public void GetScripture()
    // {
    //     Console.WriteLine("What scripture would you like to")
    // }

}