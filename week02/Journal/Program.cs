using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();         
        PromptGenerator promptGenerator = new PromptGenerator();

        int pick = 0;

        while (pick != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? Please select a number from the following options:");
            pick = int.Parse(Console.ReadLine()); 

            if (pick == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                string entryText = Console.ReadLine();
                Console.WriteLine("How are you feeling today? or What is your mood today?");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = entryText;
                entry._mood = mood;

                journal._entries.Add(entry);
            }
            else if (pick == 2)
            {
                journal.DisplayEntries();
            }
            else if (pick == 3)
            {
                Console.Write("Enter the filename please!!: ");
                string filename = Console.ReadLine();
                journal.saveToFile(filename);
            }
            else if (pick == 4)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.loadFromFile(filename);
            }
            else if (pick == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please select a number from 1 to 5.");
            }
        }
    }
}