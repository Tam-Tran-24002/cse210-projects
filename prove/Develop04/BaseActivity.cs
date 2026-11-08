using System;
using System.Threading;

public abstract class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _timesCompleted;
    private int _totalSeconds;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _timesCompleted = 0;
        _totalSeconds = 0;
    }

    public string GetName()
    {
        return _name;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public abstract void Run();

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = ReadPositiveNumber();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);

        _timesCompleted++;
        _totalSeconds += _duration;
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string number = i.ToString();
            Console.Write(number);
            Thread.Sleep(1000);

            // Erase every digit so that 10 -> 9 does not leave a stray character.
            string back = new string('\b', number.Length);
            string blank = new string(' ', number.Length);
            Console.Write(back + blank + back);
        }
    }

    public string GetSummary()
    {
        return $"{_name}: completed {_timesCompleted} time(s), {_totalSeconds} seconds total";
    }

    private int ReadPositiveNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value > 0)
            {
                return value;
            }

            Console.Write("Please enter a whole number greater than 0: ");
        }
    }
}