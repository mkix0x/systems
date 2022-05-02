using UnityEngine;

class AchievementDebug : MonoBehaviour
{
    private void OnEnable()
    {
        AchievementSystem.AchievementUnlocked += x => Debug.Log($"Achievement Unlocked: {x.Name}!");
    }
}
