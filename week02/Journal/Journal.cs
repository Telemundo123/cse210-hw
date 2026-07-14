using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }
     
    public void loadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                entry._mood = parts[3]; // This is the "Exceeding the requirements" part of the assignment. I added a mood question to the journal entry.
                _entries.Add(entry);
            }

                Console.WriteLine("Entries loaded successfully.");
    }
    
    public void saveToFile(string filename)
    {
        
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine(entry.SaveFormat());
            }
        }

        Console.WriteLine("Journal saved.");
    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}
