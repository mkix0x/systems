// ReSharper disable once ClassNeverInstantiated.Global
class Achievement
{
    public Achievement(string name, IAchievementUnlockCondition unlockCondition)
    {
        Name = name;
        UnlockCondition = unlockCondition;
    }

    public readonly string Name;
    public readonly IAchievementUnlockCondition UnlockCondition;
    public bool Unlocked;
}
