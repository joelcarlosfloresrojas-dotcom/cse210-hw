using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class SimpleGoal: Goal
{
    private bool _isComplete;
    

    public void SetIsComplete(bool keep)
{
    _isComplete = keep;
}

    public SimpleGoal(string shortname,string description,int points):base(shortname,description,points)
    {
        _isComplete=false;
    }


    public override int RecordEvent()
    {
        _isComplete=true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        return GetPoints();
    }

    public override bool IsCompleted()
    {
        
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        
        return $"Simple Goal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}