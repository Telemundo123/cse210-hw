using System;

public class Entry
{
    public string _date;
    public string _promptText;

    public string _entryText;

    public string _mood; // This is the "Exceeding the requirements" part of the assignment. I added a mood question to the journal entry.

    public Entry()
    {

    }

    public string SaveFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_mood}";
    }

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"{_mood}"); // This is the "Exceeding the requirements" part of the assignment. I added a mood question to the journal entry.
    }
}
