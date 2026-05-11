using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // ask user for grade percentage.
        Console.Write("What is your grade: ");
        string valueFromUser = Console.ReadLine();

        // convert string input to int
        int percent = int.Parse(valueFromUser);
        
        string letter = "";

        if (percent >= 90)
        {
            // print A
            // Console.WriteLine("A");
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine($"congratulations! You passed your exam.");
        }
        else 
        {
            Console.WriteLine($"Sorry, try again next time.");
        }

    
        // example try
    
        // int x = 88;
        // int y = 88;

        // if (x > y)
        // {
        //     Console.WriteLine("great");
        // }
        // else if (x < y)
        // {
        //     Console.WriteLine("not great");
        // }
        // else
        // {
        //     Console.WriteLine("equal");
        // }


    }

}