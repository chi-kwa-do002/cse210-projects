using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
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

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text;
    }
}
