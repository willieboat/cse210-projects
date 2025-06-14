class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0;
    public override double GetSpeed() => (GetDistance() / GetLengthInMinutes()) * 60;
    public override double GetPace() => GetLengthInMinutes() / GetDistance();
}
