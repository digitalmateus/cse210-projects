using System;
using System.ComponentModel;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetNumberComments()
    {
        return _comment.Count;
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }
}