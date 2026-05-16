using System;

public class PromptGenerator
{
    // create a list of prompts for the journal
    public List<string> _prompts = new List<string>();

    // constructor method to initialize the list of prompts AND runs when object is created
    public PromptGenerator()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("What made you happy today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What challenge did you face today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is your favorite food?");
        _prompts.Add("What is your favorite movie?");
     
    }

    public string GetRandomPrompt()
    {
        // Implementation for getting a random prompt from user and returning it
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}