public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    //constructor
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone else succeed."
        };

        _questions = new List<string>
        {
            "How did you feel when you completed this task?",
            "What did you learn about yourself through this experience?",
            "How can you apply this learning to other areas of your life?"
        };
    }

    //method to display the reflection activity information
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"Consider the following prompt: {prompt}");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine(question);

            ShowSpinner(3);
        }
        DisplayEndingMessage();
    }
    
}