using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random magicNumberGenerator = new Random();
        int magicNumber = magicNumberGenerator.Next(1,101);

        Console.Write("What is your guess? ");
        int guess = Convert.ToInt32(Console.ReadLine());

        while (guess != magicNumber)
        {
            Console.WriteLine("Wrong Guess, Please Try again!");
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}