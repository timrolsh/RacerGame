using UnityEngine;

[CreateAssetMenu(fileName = "ObstacleAsset", menuName = "Game/Obstacle Asset")]
public class ObstacleAsset : ScriptableObject
{
    public ObstacleType obstacleType;
    public ObstacleLocation obstacleLocation;
    public delegate void ObstacleAction();
    public event ObstacleAction OnScore;
    public event ObstacleAction OnDeath;

    public void TriggerScore()
    {
        OnScore?.Invoke();
    }

    public void TriggerDeath()
    {
        OnDeath?.Invoke();
    }
}
