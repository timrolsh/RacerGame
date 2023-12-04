using UnityEngine;
public class Obstacle : MonoBehaviour
{
    public ObstacleAsset obstacleAsset;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Car"))
        {
            if (obstacleAsset.obstacleType == ObstacleType.Cone || obstacleAsset.obstacleType == ObstacleType.BigCone)
            {
                obstacleAsset.TriggerScore();
            }
            else
            {
                obstacleAsset.TriggerDeath();
            }
        }
    }

    void Start()
    {
        obstacleAsset.OnScore += HandleScore;
        obstacleAsset.OnDeath += HandleDeath;
    }

    private void HandleScore()
    {
        ScoreManager.Instance.ScoreBoost();
    }

    private void HandleDeath()
    {
        // Handle death logic here
    }

    void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks
        obstacleAsset.OnScore -= HandleScore;
        obstacleAsset.OnDeath -= HandleDeath;
    }
}
