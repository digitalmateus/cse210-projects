using System;

public class NewBaseType
{
    public string _promptText;
}

public class Entry : NewBaseType
{
    public string _date;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date} { _promptText} { _entryText}");

        // Console.WriteLine($"Date: {_date}");
        // Console.WriteLine($"Prompt: {_promptText}");
        // Console.WriteLine($"Entry: {_entryText}");
        // Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromString(string line)
    {
        var parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}