using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}. ");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine(firstName);

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }

}
