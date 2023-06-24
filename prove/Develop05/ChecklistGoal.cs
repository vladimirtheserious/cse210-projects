class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int Bonus { get; }
    public int Count { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        Count = 0;
    }

    public override void Complete()
    {
        Count++;
        if (Count >= TargetCount)
            IsCompleted = true;
    }

    public override string GetStatus()
    {
        return $"Completed {Count}/{TargetCount} times";
    }
}