using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text_list) 
    {
        _text = text_list;
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
        if (_isHidden == true)
        {
            string op1 = ""; 
            for (int go = 0; go < _text.Length; go++) 
            {
                op1 += "_";
            }
            return op1;
        }
        else
        {
            return _text;
        }
    }
}