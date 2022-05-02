using System;
using System.Collections.Generic;

// ReSharper disable once ClassNeverInstantiated.Global
class AchievementSystem
{
    public AchievementSystem(Dictionary<string, Achievement> idToAchievement)
    {
        this.idToAchievement = idToAchievement;
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public void TryUnlock(string id)
    {
        if (!idToAchievement.ContainsKey(id))
            return;

        var achievement = idToAchievement[id];
        if (achievement.Unlocked)
            return;

        if (!achievement.UnlockCondition.CanUnlock())
            return;

        achievement.Unlocked = true;
        AchievementUnlocked?.Invoke(achievement);
    }

    public void TryUnlockAchievements()
    {
        foreach (var item in idToAchievement)
        {
            TryUnlock(item.Key);
        }
    }

    private readonly Dictionary<string, Achievement> idToAchievement;

    public static event Action<Achievement> AchievementUnlocked;
}
