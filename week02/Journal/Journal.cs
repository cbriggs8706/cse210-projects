using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What made me smile or laugh today?",
        "What challenge did I face today, and how did I handle it?",
        "What was one moment of peace or calm in my day?",
        "Who did I serve or help today?",
        "Who helped or inspired me today?",
        "What decision did I make today that I feel good about?",
        "What do I want to remember about today?",
        "What is something I want to improve tomorrow?",
        "What thoughts or worries were on my mind most today?",
        "How did I take care of my physical or mental health today?",
        "What beauty did I notice in the world around me?",
        "What scripture or quote stood out to me today?",
        "What did I do today that brought me closer to God?",
        "What am I excited about for tomorrow?",
        "What surprised me today?",
        "Did I have any quiet impressions or promptings today?",
        "What habit am I building or breaking?",
        "How did I show love or kindness today?",
        "If I had to describe today in one word, what would it be?",
        "What am I learning about myself lately?",
    };

    public void WriteEntry()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response);
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine("Journal saved.");
    }
public void SaveToJsonFile(string filename)
{
    string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filename, jsonString);
    Console.WriteLine("Journal saved to JSON.");
}

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromFileFormat(line));
        }
        Console.WriteLine("Journal loaded.");
    }

    public void LoadFromJsonFile(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string jsonString = File.ReadAllText(filename);
    _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
    Console.WriteLine("Journal loaded from JSON.");
}

}
