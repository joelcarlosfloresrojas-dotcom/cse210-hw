using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference ref1, string text_list)
    {
        _reference = ref1;
        _words = new List<Word>();

        string[] _hello = text_list.Split(' '); 
        for (int go = 0; go < _hello.Length; go++) 
        {
            Word word1 = new Word(_hello[go]); 
            _words.Add(word1);
        }
    }

    public void HideRandomWords(int nhide) 
    {
        Random random = new Random();
        int rnumber = 0; 
        int enumber = 0; 

        while (rnumber < nhide && enumber < 50)
        {
            int go = random.Next(_words.Count); 
            
            if (_words[go].IsHidden() == false)
            {
                _words[go].Hide();
                rnumber++;
            }
            enumber++;
        }
    }

    public string GetDisplayText()
    {
        string _learn = _reference.GetDisplayText() + " "; 
        
        for (int go = 0; go < _words.Count; go++)
        {
            _learn += _words[go].GetDisplayText() + " ";
        }
        
        return _learn;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;

        foreach (Word word1 in _words) 
        {
            if (word1.IsHidden() == false)
            {
                allHidden = false;
            }
        }
        
        return allHidden;
    }
}