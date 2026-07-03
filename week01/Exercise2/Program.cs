using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        String Letter = "";

        if (grade >= 90)
        {
            Letter = "A";
        }
        else if (grade >= 80)
        {
            Letter = "B";
        }
        else if (grade >= 70)
        {
            Letter = "C";
        }
        else if (grade >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"You have grade {Letter}!");

        if (grade >= 70)
        {
             Console.WriteLine("Congratulations! You have passed the course!");
        }
        else
        {
            Console.WriteLine("You have failed the course! Keep trying!");
        }
    }
}