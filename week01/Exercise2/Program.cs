using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {
            Console.WriteLine("You have grade A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You have grade B!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You have grade C!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You have grade D!");
        }
        else
        {
            Console.WriteLine("You have grade F!");
        }

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