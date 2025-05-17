using System;
using System.Collections.Generic;


public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenge you faced recently.",
        "What made you smile today?",
        "What goals are you working toward?",
        "How did you take care of yourself today?"
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}