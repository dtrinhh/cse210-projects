using System;

class Video
{
    private string _title;

    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public int CommentAmount()
    {
        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nCreator: {_author}\nDuration: {_length} seconds\nComments: {CommentAmount()} ");
        Console.WriteLine();
    }

    public void DisplayComments()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"Commenter Name: {c.GetCommenterName()}");
            Console.WriteLine($"Comment: {c.GetCommentText()}");
            Console.WriteLine();
        }
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}