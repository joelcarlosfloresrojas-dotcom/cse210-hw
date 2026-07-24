
public class Reference
{
    private string _book;
    private string _chapter;
    private string _star;
    private string _end;

    public Reference(string b,string c, string s,string e)
    {
        _book = b;
        _chapter= c;
        _star=s;
        _end=e;
    }
     public Reference(string b,string c, string s)
    {
        _book = b;
        _chapter= c;
        _star=s;
        _end="";
    }
    public string GetDisplayReference()
    {
        string op1;

        if (string.IsNullOrEmpty(_end))
        {
            op1=$"{_book} {_chapter}:{_star}";   
        }
        else{
            int enumber = int.Parse(_end);
            if (enumber == 0 )
            {
                op1=$"{_book} {_chapter}:{_star}";
            }
            else
            {
                op1=$"{_book} {_chapter}:{_star}-{_end}";
            }
        }
        return op1;
    }
    
    
}