using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }

    public void Start()
    {
        DisplayStartMessage();
        ShowSpinner(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            Console.Clear();
        }

        DisplayEndMessage();
    }

    public void Run()
    {
        Start();
    }
}