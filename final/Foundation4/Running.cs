class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int lengthMinutes, double distanceKm) : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }
}
