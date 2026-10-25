// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Word myWord = new Word("Secret");

//         // myWord.Display();
//         // myWord.Hide();
//         // Console.WriteLine();
//         // myWord.Display();

//         Scripture myScripture = new Scripture("Moses", 1, 39,
//             "Behold, this is my work and my glory, to bring to pass the immortality and eternal life of man.");

//         myScripture.ShowScripture();
//     }
// }





using System;

// What I did to go beyond the requirements:
// 1. The program reads scriptures from a file (scriptures.txt) and picks one
//    at random. I made a ScriptureLibrary class to handle this. If the file
//    isn't there, it uses Proverbs 3:5-6 instead.
// 2. You can type "hint" to show one hidden word if you get stuck.
// 3. It shows your progress: how many words are hidden and how many hints
//    you've used.
// 4. It only hides words that aren't already hidden, so every time you
//    press enter, new words disappear.
// 5. Hidden words keep their punctuation (like "_____,") so you can still
//    see where sentences start and stop.

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadFromFile(Path.Combine(AppContext.BaseDirectory, "scriptures.txt"));

        if (library.GetCount() == 0)
        {
            library.AddScripture(new Scripture(
                new ScriptureReference("Proverbs", 3, 5, 6),
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        }

        Scripture scripture = library.GetRandomScripture();
        int hintsUsed = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine($"Progress: {scripture.GetHiddenCount()} of {scripture.GetWordCount()} words hidden | Hints used: {hintsUsed}");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job!");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide more words, type 'hint' to reveal a word, or type 'quit' to finish:");
            string input = (Console.ReadLine() ?? "").Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                if (scripture.RevealRandomWord())
                {
                    hintsUsed++;
                }
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}