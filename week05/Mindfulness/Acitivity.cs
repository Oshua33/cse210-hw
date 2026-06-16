public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    //constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //method to get the name of the activity
    public string GetName()
    {
        return _name;
    }

    //method to get the description of the activity
    public string GetDescription()
    {
        return _description;
    }

    

    //method to display the starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();
        
        //show the welcome message and description of the activity
        Console.WriteLine($"Welcome to {GetName()}...");
        Console.WriteLine();

        Console.WriteLine(GetDescription());
        Console.WriteLine();

    //ask the user for the duration of the activity
        Console.Write("How long, in seconds, would you like to do this activity?    ");

        _duration = int.Parse(Console.ReadLine());

    //set the duration of the activity and show a get ready message
        Console.WriteLine("Get ready...");
        ShowSpinner(3); 
    }

    public void DisplayEndingMessage()
    {
        //show a well done message and the duration of the activity
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetName()} for {_duration} seconds.");

        ShowSpinner(3);
    }

    //method to show a spinner animation
    public void ShowSpinner(int seconds)
    {
        //create a loading animation using a list of characters
        List<string> spinner = new List<string>
        {
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);

              Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }


}