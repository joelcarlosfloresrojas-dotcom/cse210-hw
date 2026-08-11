using System.Diagnostics;

public class Swimming:Activity
{
    private double _swimmingLaps;


    public Swimming(int length, double swimmingLaps) : base(length, "Swimming")
    {
        _swimmingLaps=swimmingLaps;
    }
    public override double Distance()
    {
        return _swimmingLaps * 50 / 1000;
    }

    public override double Speed()
    {
        return Distance() / GetLength() * 60;
    }

    public override double Pace()
    {
        return GetLength()/Distance();
    }
  
    
}