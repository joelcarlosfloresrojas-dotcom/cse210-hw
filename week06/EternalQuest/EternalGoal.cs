using System.Globalization;

public class EternalGoal:Goal
{
    public EternalGoal(string shortname,string description,int points) : base(shortname, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
        return GetPoints();
    }

    public override bool IsCompleted()
    {
        
        return false;
    }

     public override string GetStringRepresentation()
    {
        
        return $"Eternal Goal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }
}