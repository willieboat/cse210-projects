class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        this.isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return points;
        }
        return 0;
    }

    public override bool IsComplete() => isComplete;

    public override string GetDetails() => $"[{(isComplete ? "X" : " ")}] {name} ({description})";

    public override string GetStringRepresentation() => $"SimpleGoal:{name},{description},{points},{isComplete}";
}