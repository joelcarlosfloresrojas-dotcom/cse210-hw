public class Assignment
{
    private string _studentName;
    private string _topic;


    public Assignment(string a, string b)
    {
        _studentName=a;
        _topic=b;
    }


    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }

}