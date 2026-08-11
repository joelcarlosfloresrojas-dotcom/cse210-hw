public abstract class Goal
{
    private string _shortname;
    private string _description;
    private int _points;

    public Goal(string shortname,string description,int points)
    {
        _shortname=shortname;
        _description=description;
        _points=points;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortname;
    }

     public abstract int RecordEvent();
    public abstract bool IsCompleted();
    public  virtual string GetDetailsString()
    {
        string mark;

        if (IsCompleted() == true)
        {
            mark = "X";
        }
        else
        {
            mark = " ";
        }
        string hola=$"[{mark}] {_shortname} ({_description})";
        return hola;
    }
    public abstract string GetStringRepresentation();
    
}