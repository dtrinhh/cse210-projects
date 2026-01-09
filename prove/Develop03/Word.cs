using System;

public class Word
{
    // public or private?
    public bool _isHidden;

    public string _text;
    public Word _word;

    public class HideWord()
    {

    }

    public class RandomWords()
    {

    }

    public void Display()
    {
        Console.WriteLine(_text);
    }

    public Word(string text)
    {
        _text = text;
    }
    // public Word(string text)
    // {
    //     _text = text;
    // }






}