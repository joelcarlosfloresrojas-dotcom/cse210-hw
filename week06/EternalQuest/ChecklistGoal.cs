public class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;




    public ChecklistGoal(string shortname,string description,int points,int target,int bonus) : base(shortname, description, points)
    {
        _target=target;
        _bonus=bonus;
        _amountCompleted=0;
    }


    public void SetAmount(int setter)
    {
         _amountCompleted=setter;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_target != _amountCompleted)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points");
            return GetPoints();

        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned { _bonus+GetPoints()} points");
            return _bonus+GetPoints();    
        }
        

    }

    public override bool IsCompleted()
    {
        if (_amountCompleted != _target)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    public override string GetStringRepresentation()
    {
        
        return $"Check List Goal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
    
    public override string GetDetailsString()
    {
        string mark = IsCompleted() ? "X" : " ";
        string hola=$"[{mark}] {GetShortName()} ({GetDescription()}) ---- currently completed {_amountCompleted}/{_target}";
        return hola;
    }

}