using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] rawWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string rawWord in rawWords)
        {
            _words.Add(new Word(rawWord));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Here I Build a list of indices for words that are not already hidden
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }

        int hideCount = Math.Min(numberToHide, availableIndices.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int randomPick = _random.Next(availableIndices.Count);
            int wordIndex = availableIndices[randomPick];
             // This is the extra requirement, I made sure that the word that was previously hidden, shouldn't be hidden again!!
             // I ensured this by removing it's index from the availableIndices list.
            _words[wordIndex].Hide();
            availableIndices.RemoveAt(randomPick);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}