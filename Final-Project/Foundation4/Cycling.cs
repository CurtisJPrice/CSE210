public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * (_lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return (60.0 / _speed);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling - Distance {GetDistance():F2} km, Speed: {_speed:F2} kph, Pace: {GetPace():F2} min per km";
    }
}