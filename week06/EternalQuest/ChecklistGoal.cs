class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = currentCount;
        this.bonus = bonus;
    }

    public override int RecordEvent()
    {
        int earned = 0;
        if (currentCount < targetCount)
        {
            currentCount++;
            earned += points;
            if (currentCount == targetCount)
                earned += bonus;
        }
        return earned;
    }

    public override bool IsComplete() => currentCount >= targetCount;

    public override string GetDetails() => $"[{(IsComplete() ? "X" : " ")}] {name} ({description}) -- Completed: {currentCount}/{targetCount}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{name},{description},{points},{bonus},{targetCount},{currentCount}";
}
