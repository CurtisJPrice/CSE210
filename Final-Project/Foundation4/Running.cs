public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return (_lengthInMinutes / _distance);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Running - Distance {_distance:F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}