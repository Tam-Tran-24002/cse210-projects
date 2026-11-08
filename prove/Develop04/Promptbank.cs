using System;
using System.Collections.Generic;

// Hands out prompts in random order without repeating any of them
// until every prompt in the list has been used once this session.
public class PromptBank
{
    private List<string> _prompts;
    private List<string> _unused;
    private Random _random;

    public PromptBank(List<string> prompts)
    {
        _prompts = new List<string>(prompts);
        _unused = new List<string>(prompts);
        _random = new Random();
    }

    public string GetNext()
    {
        if (_unused.Count == 0)
        {
            _unused = new List<string>(_prompts);
        }

        int index = _random.Next(_unused.Count);
        string prompt = _unused[index];
        _unused.RemoveAt(index);
        return prompt;
    }
}