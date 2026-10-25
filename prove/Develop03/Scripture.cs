// class Scripture
// {
//     private List<Word> _words;

//     // TODO - Add scripture reference

//     public Scripture(string bookName, int chapter, int verse, string text)
//     {
//         _words = ConvertToWordList(text);

//         _words[7].Hide();
//         // TODO
//     }

//     public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
//     {
//         _words = ConvertToWordList(text);
//         // TODO
//     }

//     public void ShowScripture()
//     {
//         foreach (Word word in _words)
//         {
//             word.Display();
//         }
//     }

//     // TODO - Add constructor for ScriptureReference

//     /******************************************************************
//      * ConvertToWordList() - this method will receive a string parameter,
//      * which is a paragraph of text. It will split that text into words
//      * and add those words to a List<Word> and return the list
//      ******************************************************************/
//     private List<Word> ConvertToWordList(string text)
//     {
//         List<Word> tempWordList = new List<Word>();
//         string[] tempWords = text.Split(' ');
//         foreach (string w in tempWords)
//         {
//             Word tempWord = new Word(w);
//             tempWordList.Add(tempWord);
//         }

//         return tempWordList;
//     }
// }

using System;
using System.Collections.Generic;

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
        public bool RevealRandomWord()
    {
        List<Word> hiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        if (hiddenWords.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        hiddenWords[random.Next(hiddenWords.Count)].Show();
        return true;
    }

    public int GetHiddenCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
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