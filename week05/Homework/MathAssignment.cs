public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;
   public MathAssignment(string a,string b,string c,string d) :base(a,b)
    {
        _textbookSection=c;
        _problems=d;

    }
    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}