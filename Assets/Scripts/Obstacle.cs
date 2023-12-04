using UnityEngine;
public class Obstacle : MonoBehaviour
{
    public ObstacleAsset obstacleAsset;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // You can check the Obstacle type and call the respective delegate
            switch (obstacleAsset.obstacleType)
            {
                case ObstacleType.Cone:
                case ObstacleType.BigCone:
                    // Assuming these types increase score
                    obstacleAsset.TriggerScore();
                    break;
                case ObstacleType.Barrier:
                case ObstacleType.PyramidBarrier:
                    // Assuming these types cause death
                    obstacleAsset.TriggerDeath();
                    break;
                    // Add other cases as needed
            }
        }
    }
}
