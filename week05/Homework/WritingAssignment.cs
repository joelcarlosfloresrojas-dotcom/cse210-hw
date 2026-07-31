public class WritingAssignment:Assignment
{
    private string _title;
    private string _author;


     public WritingAssignment(string a,string b,string c,string d) :base(a,b)
    {
        _title=c;
        _author=d;

    }
    public string GetWritingInformation()
    {
        return  _title + " " + _author;
    }
}