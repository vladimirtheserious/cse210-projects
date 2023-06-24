class EternalGoal : Goal
{
    public int Count { get; private set; }

    public EternalGoal(string name, int value) : base(name, value)
    {
        Count = 0;
    }

    public override void Complete()
    {
        Count++;
    }

    public override string GetStatus()
    {
        return $"Completed {Count} times";
    }
}