using System.Globalization;
public abstract class Activity
{
    private string _date;
    private int _length;    
    private string _activityName;
    public Activity(int length,string activityName)
    {
        _date = DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("en-US"));
        _length=length;
        _activityName = activityName;
    }

    
    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }
    

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {_activityName} ({GetLength()} min)- Distance: {Distance():0.0} km, Speed: {Speed():0.0} kph, Pace: {Pace():0.0} min per km";
    }
} 