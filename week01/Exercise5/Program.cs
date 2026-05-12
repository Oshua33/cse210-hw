using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = GetUserName();
        int favoriteNumber = GetFavoriteNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(name, square);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
    }
}