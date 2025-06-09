using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last form {_duration} secondes.");
        Console.WriteLine("Get ready...");
        System.Threading.Thread.Sleep(2000); // 2 seconds delay
        Console.Clear();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            index = (index + 1) % spinner.Length;
            System.Threading.Thread.Sleep(200); // time in miliseconds
        }
    }

    public void ShowCountdown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            TimeSpan timeLeft = endTime - DateTime.Now;
            Console.Write($"{timeLeft.Seconds} ...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}