public class hold
{
    private int _top;
    private int _bottom;

    public hold()
    {
        _bottom=1;
        _top=1;
    }

    public hold(int top)
    {
        _bottom=1;
        _top=top;
    }

    public hold(int up,int down)
    {
        _top=up;
        _bottom=down;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}