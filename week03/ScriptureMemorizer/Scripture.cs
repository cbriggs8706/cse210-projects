using System;
using System.Collections.Generic;

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;

        for (int i = 0; i < wordsToHide; i++)
        {
            List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());
            if (visibleWords.Count == 0)
                break;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }

        if (!_reference.IsFullyHidden() && _random.NextDouble() < 0.5)
        {
            _reference.HideRandomPart();
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.IsHidden()) && _reference.IsFullyHidden();
    }
}
