public class Word
{
    private List<string> _hello = new List<string>();
    private int _numbertohide;
    private List<bool> _hiddenStatus = new List<bool>();

    public Word(string text_list, int nhide)
    {
        _hello = text_list.Split().ToList();
        _numbertohide = nhide;  
        
        for (int i = 0; i < _hello.Count; i++)
        {
            _hiddenStatus.Add(false);
        }
    }

    public List<string> GetWords()
    {
        return _hello;
    }

    public bool IsCompletelyHidden()
    {
        return !_hiddenStatus.Contains(false);
    }

    public void Hide(int helpern)
    {
        _hiddenStatus[helpern] = true;
    }

    public bool IsHidden(int helpern)
    {
        return _hiddenStatus[helpern];
    }

    public List<int> GetRamdonChose()
    {
        List<int> randomNumbers = new List<int>();
        Random random = new Random();
        
        int remainingWords = 0;
        for (int i = 0; i < _hiddenStatus.Count; i++)
        {
            if (!_hiddenStatus[i]) 
            {
                remainingWords++;
            }
        }

        int limit = Math.Min(_numbertohide, remainingWords);

        for (int i = 0; i < limit; i++)
        {
            int rnumber = random.Next(0, _hello.Count);
            
            if (IsHidden(rnumber))
            {
                i--;
            }
            else
            {
                Hide(rnumber);
                randomNumbers.Add(rnumber);
            }
        }
        
        return randomNumbers;
    }
}