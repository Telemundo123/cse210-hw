using System;

public class Entry
{
    public string _date;
    public string _promptText;

    public string _entryText;

    public string _mood;

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
        Console.WriteLine($"{_mood}");
    }
}
