public class Running:Activity
{
    private double _distance;
    public Running(int length, double distance) : base(length, "Running")
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
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