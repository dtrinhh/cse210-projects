using System;

public class Reference
{
    private string _book;

    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    // Needed?
    // public string ToString()
    // {
    //     Console.WriteLine();
    // }

    // public void Display()
    // {
    //     if (_endVerse != 0)
    //     {
    //         Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
    //     }

    //     else if (_endVerse == 0)
    //     {
    //         Console.WriteLine($"{_book} {_chapter} {_startVerse}");
    //     }
    // }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        // Console.Write($"{_book} {_chapter} {_startVerse} ");
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

        // Console.Write($"{_book} {_chapter} {_startVerse} {_endVerse} ");
    }

    public string GetSingleReference()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }
    public string GetMultiReference()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }








}