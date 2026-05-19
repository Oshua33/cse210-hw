using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.Write("Enter the numerator: ");
        int numerator = int.Parse(Console.ReadLine());
        Console.Write("Enter the denominator: ");
        int denominator = int.Parse(Console.ReadLine());

        // create the three different constructors
        Fraction fraction = new  Fraction();
        Fraction fraction1 = new Fraction(numerator);
        Fraction fraction2 = new Fraction(numerator, denominator);

        //lets use the getters and settters to set the value of the top and bottom of the fraction to the user
        fraction.SetTop(7);
        fraction.SetBottom(4);

        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        //display the fraction as a string to the user
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction2.GetFractionString());

        //display the decimal value of the fraction to the user
        Console.WriteLine($"The decimal value of the fraction is {fraction.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of the fraction is {fraction1.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of the fraction is {fraction2.GetDecimalValue()}");
    }

      
}