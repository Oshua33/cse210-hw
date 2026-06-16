using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        //create the math assignment object
        MathAssignment mathAssignment = new MathAssignment(
            "John Doe", "Multiplication", "Section 1.2", "Problems 1-10");

        //display the math assignment information
        Console.WriteLine(mathAssignment.GetHomeworkList());

        //create the writing assignment object
        WritingAssignment writingAssignment = new WritingAssignment(
            "Jane Doe", "Shakespeare", "Hamlet");


        //display the writing assignment information
        Console.WriteLine(writingAssignment.GetWritingInformation());   
    }
}