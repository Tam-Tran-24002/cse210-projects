using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            return;
        }

        foreach (string line in File.ReadAllLines(filename))
        {
            if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith("#"))
            {
                continue;
            }

            string[] parts = line.Split('|');
            if (parts.Length != 5)
            {
                continue;
            }

            string book = parts[0].Trim();
            if (!int.TryParse(parts[1], out int chapter) || !int.TryParse(parts[2], out int startVerse))
            {
                continue;
            }

            ScriptureReference reference;
            if (int.TryParse(parts[3], out int endVerse) && endVerse > 0)
            {
                reference = new ScriptureReference(book, chapter, startVerse, endVerse);
            }
            else
            {
                reference = new ScriptureReference(book, chapter, startVerse);
            }

            _scriptures.Add(new Scripture(reference, parts[4].Trim()));
        }
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public int GetCount()
    {
        return _scriptures.Count;
    }

    public Scripture GetRandomScripture()
    {
        return _scriptures[_random.Next(_scriptures.Count)];
    }
}