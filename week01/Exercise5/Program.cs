using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        String name = PromptUserName();

        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);

    }
    // Displaying a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to a wonderful Program");
    }
    // Prompting the user for their name
    static String PromptUserName()
    {
        Console.Write("What  is your name? ");
        String name = Console.ReadLine();
        return name;
    }
    // Prompting the user for a number
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    // Squaring the number
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    // Displaying the results
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squaredNumber}");
    }

}