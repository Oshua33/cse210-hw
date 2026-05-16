using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal App.");


        //create one journal and one prompt generator object to use in the application
        // get a random question from the prompt generator and display it to the user
        Journal Journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        while (true)
        {
            // Choose from the list of options and display the options to the user

            List<string> options = new List<string>();
            options.Add("1. Write a journal entry");
            options.Add("2. Display journal entries");
            options.Add("3. Save journal entries to a file");
            options.Add("4. Load journal entries from a file");
            options.Add("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            //option1: write a journal entry
            if (choice == "1")
             {
                 // Get random prompt and display it to the user
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                // Ask the user for their response to the prompt
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                //create a new entry with the prompt and response and add it to the journal
                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date = dateText;
                entry._entryText = response;
                entry._promptText = prompt;

                //store or add the entry in the journal
                Journal.AddEntry(entry);
                 
             }
             else if (choice == "2")
             {
                 // Handle displaying journal entries
                 //loop through the journal entries and display them to the user
                 Journal.DisplayAll();

             }
             else if (choice == "3")
             {
                // Handle saving journal entries to a file
                Journal.SaveToFile();
             }
             else if (choice == "4")
             {
                // Handle loading journal entries from a file
                Journal.LoadFromFile();
             }
             else if (choice == "5")
             {
                 // Handle quitting the application
                 Console.WriteLine("Goodbye, Have a nice day!");
                 break;
             }
             else
             {
                 Console.WriteLine("Invalid choice. Please try again.");
             }
        }
          
    }
}