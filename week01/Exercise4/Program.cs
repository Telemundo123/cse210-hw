using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // Create a list to store the numbers entered by the user
        List<int> numbers = new List<int>();
        // Prompt the user to enter numbers until they enter 0
        int number = -1;

        while (number != 0)
        {
           Console.Write("Enter a number: ");
           number = int.Parse(Console.ReadLine());
           if (number != 0)
           {
               numbers.Add(number);
           }
        }
        // Calculate the sum, average, and largest number from the list
        int sum = 0;
        foreach (int item in numbers)
        {
           sum += item; 
        }

        double average = (double)sum / numbers.Count;

        int largest = numbers[0];
        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        // Printed the results to the console
        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The average of the numbers is {average}");
        Console.WriteLine($"The largest number is {largest}");

        
    }
}