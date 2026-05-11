using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        // create empty list
        List<int> numbers = new List<int>();

// create variable to store user input, and initialize it to -1
        int userInput = -1;
        
        // keep asking user for input until they enter 0
        while (userInput != 0)
        {
            // ask for user to input a number, then convert it to integer
            Console.Write("Enter a number: ");
            string userInputString = Console.ReadLine();
            userInput = int.Parse(userInputString);

            // add user number input to list
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        }

        Console.WriteLine("you have entered the following numbers: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    // SUM
    //    creating sum variable to store the sum of the numbers in the list, and initialize it to 0
        int sum = 0;

        // loop through the list of numbers and add each number to the sum variable
         foreach (int number in numbers)
        {
            // add number to sum variable
            sum += number;
        }

    // AVERAGE
        // average is the sum of the numbers divided by the count of the numbers in the list

        double average = (double)sum / numbers.Count;

        // MAX
        // creating max variable to store the maximum number in the list, and initialize it to the first number in the list
        int max = numbers[0];

        // loop through the list of numbers and update the max variable if a larger number is found
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The maximum number is: " + max);

    }
}