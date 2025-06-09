using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity( int duration, List<string> prompts, List<string> questions) : base("Reflecting", "This activity will help you reflect on the good things in your life by having you think about them.", duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(5);
        Console.Clear();

        GetRandomPrompt();
        Console.WriteLine("Take a moment to think about this prompt...");
        ShowCountdown(5);
        Console.Clear();

        Console.WriteLine("Now, let's reflect on some questions.");
        ShowSpinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
            ShowSpinner(5); // Reflect on the question
            Console.Clear();
        }

        DisplayEndMessage();
    }

    
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine($"Prompt: {randomPrompt}");
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];
        Console.WriteLine($"Question: {randomQuestion}");
        Console.WriteLine("Think about this question...");
    }


    public void DisplayPrompt()
    {
        GetRandomPrompt();
    }

    public void DisplayQuestion()
    {
        GetRandomQuestion();
    }

}