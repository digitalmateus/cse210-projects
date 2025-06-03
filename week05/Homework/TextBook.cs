using System;

public class TextBook
{
    protected string _topic;
    protected string _section;
    protected string _problem;

    public TextBook(string topic, string section, string problem)
    {
        _topic = topic;
        _section = section;
        _problem = problem;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSection()
    {
        return _section;
    }

    public string GetProblem()
    {
        return _problem;
    }
}