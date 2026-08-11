public class Cycling:Activity
{
    private double _speed;

    public Cycling(int length, double speed) : base(length, "Cycling")
        {
            _speed=speed;
        }

    public override double Distance()
    {
        return Speed() * GetLength() / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    
}