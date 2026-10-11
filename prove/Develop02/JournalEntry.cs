using System;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    public void CreateJournalEntry()
    {
        string[] prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How was your day?",
            "Talk about someone you met."
        };

        Random random = new Random();
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string CreateFileSystemString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }
}