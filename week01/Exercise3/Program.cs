using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        // Enter magic number ?
        Console.Write("Whats your magic number? ");
        string magicNumberInput = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberInput);

        // Enter guess?
        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guess = int.Parse(guessInput);
        
        int count = 0;
        
        while (guess != magicNumber)
        {
            count = count + 1;
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }
            
            Console.Write("What is your guess? ");
            guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

        }
        
        Console.WriteLine("Congratulations! You guessed the magic number.");

        Console.WriteLine($"It took you {count} tries to guess the magic number.");
    }
}