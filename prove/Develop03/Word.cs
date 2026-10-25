// using System.Diagnostics.Contracts;

// class Word
// {
//     private string _word;
//     private bool _hidden;

//     public Word(string word)
//     {
//         _word = word;
//         _hidden = false;
//     }

//     public bool IsHidden()
//     {
//         return _hidden;
//     }

//     public void Hide()
//     {
//         _hidden = true;
//     }
//     public string GetWordString()
//     {
//         string returnString = "";
//         if(_hidden)
//         {
//             for(int i = 0; i < _word.Length; i++)
//             {
//                 returnString +='_';
//             }
//         }
//         else
//         {
//             returnString = _word;
//         }
//         return returnString;
//     }

//     public void Display()
//     {
//         Console.Write($"{GetWordString()} ");
//     }
// }

using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        string hiddenText = "";
        foreach (char c in _text)
        {
            if (char.IsLetterOrDigit(c))
            {
                hiddenText += "_";
            }
            else
            {
                hiddenText += c;
            }
        }
        return hiddenText;
    }
}