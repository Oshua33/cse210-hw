using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //create the inputs
        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter =int.Parse(Console.ReadLine());

        Console.Write("Enter the Verse: ");
        int verse =int.Parse(Console.ReadLine());

        Console.Write("Enter the endVerse but 0 if optional: ");
        int endverse =int.Parse(Console.ReadLine());

        // ask for the text from user
        Console.Write("Enter the scripture text: ");
        string text = Console.ReadLine();


        //------  create the objects

        //create reference object
        Reference reference = new Reference(book, chapter, verse, endverse);

        //create scripture with words
        Scripture scripture = new Scripture(reference, text);

        //prompt the user for enter or quit
        //create the loop and app logic
        
        //create an empty string of user
        string input = "";

        //if the user input is not quit and the scripture is showing, you want to clear it 1st
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            //show scripture 
            Console.WriteLine(scripture.GetDisplayText());

            //ask user to enter or quit
            Console.Write("\nPress Enter to continue or type quit: ");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                //hide the random numbers with the lenghts
                scripture.HideRandomWords(4);
            }
        }

        //end when all hides
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        //user bye
        Console.WriteLine("\nProgram ended");

        
    }

}