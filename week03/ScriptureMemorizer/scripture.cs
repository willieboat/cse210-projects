using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;

        words = new List<Word>();
        foreach (var w in text.Split(' '))
        {
            words.Add(new Word(w));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);

        foreach (var w in words)
        {
            Console.Write(w.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }

    public void HideRandomWords(int count)
    {
        int hidden = 0;

        while (hidden < count && !AllWordsHidden())
        {
            int index = random.Next(words.Count);

            if (!words[index].IsHidden && !string.IsNullOrWhiteSpace(words[index].GetDisplayText()))
            {
                words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var w in words)
        {
            if (!w.IsHidden) return false;
        }
        return true;
    }
}