using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScriptures();
    }

    private void LoadScriptures()
    {
        _scriptures.Add(new Scripture(new ScriptureReference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        _scriptures.Add(new Scripture(new ScriptureReference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        _scriptures.Add(new Scripture(new ScriptureReference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy."));

        //TODO Add more scriptures here eventually
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
