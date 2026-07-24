using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string b, int c, int s) 
    {
        _book = b;
        _chapter = c;
        _verse = s;
        _endVerse = 0;
    }

    public Reference(string b, int c, int s, int e) 
    {
        _book = b;
        _chapter = c;
        _verse = s;
        _endVerse = e;
    }

    public string GetDisplayText()
    {
        string op1; 
        if (_endVerse == 0)
        {
            op1 = _book + " " + _chapter + ":" + _verse;
        }
        else
        {
            op1 = _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
        return op1;
    }
}