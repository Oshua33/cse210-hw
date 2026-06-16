public class ListingActivity : Activity
{
    private List<string> _prompts;
    
    //constructor
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life.")
    {
        _prompts = new List<string>
        {
            "Who are people you appreciate?",
            "What are your strengths?",
            "Who have you helped this week?",
            "Who are your heroes?"
        };
    }

    //method to display the listing activity information
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        string prompt =
            _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine(prompt);

        Console.WriteLine();
        Console.WriteLine("You may begin in:");

        ShowCountDown(5);

        int count = 0;

        DateTime endTime =
            DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");

        DisplayEndingMessage();
    }
}