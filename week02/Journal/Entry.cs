using System;

class Entry
{
    // create the varible 
    public string _date;
    public string _promptText;
    public string _entryText;


    public void Display()
    {
        // Implementation for displaying the entry
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}