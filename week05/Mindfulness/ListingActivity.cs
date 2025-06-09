using System;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompt;

    public ListingActivity(int duration, List<string> prompt) : base("Listing", "This activity will help you reflect on the good things in your life by having you list them.", duration)
    {
        _prompt = prompt;
    }

    public void Start()
    {
        DisplayStartMessage();
        ShowSpinner(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            foreach (string item in _prompt)
            {
                Console.WriteLine(item);
            }
            ShowCountdown(6);
            Console.Clear();
        }

        DisplayEndMessage();
    }

    public void Run()
    {
        Start();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        string randomPrompt = _prompt[index];
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.WriteLine("Take a moment to reflect on this prompt and list your thoughts.");
        Console.WriteLine("Press Enter when you are ready to continue...");
    }

    public void GetListFromUser()
    {
        Console.WriteLine("Please enter your thoughts (type 'done' when finished):");
        List<string> userList = new List<string>();
        string input;

        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            userList.Add(input);
        }

        Console.WriteLine("Your thoughts:");
        foreach (string item in userList)
        {
            Console.WriteLine($"- {item}");
        }
    }
}