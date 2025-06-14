class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent() => points;

    public override bool IsComplete() => false;

    public override string GetDetails() => $"[∞] {name} ({description})";

    public override string GetStringRepresentation() => $"EternalGoal:{name},{description},{points}";
}
