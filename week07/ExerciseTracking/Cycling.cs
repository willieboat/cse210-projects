class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * GetLengthInMinutes()) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}
