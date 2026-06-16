public class BreathingActivity : Activity
{
    //constructor
    public BreathingActivity() : base("Breathing", "This activity will help you relax and focus on your breathing.")
    {
    }

    //method to display the breathing activity information
    public string GetBreathingInformation()
    {
        return $"Breathing Activity: {GetName()} - {GetDescription()}";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4); 

            Console.WriteLine("Breathe out...");
            ShowSpinner(6); 

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}