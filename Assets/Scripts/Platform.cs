using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private readonly ObstacleType[] types = (ObstacleType[])System.Enum.GetValues(typeof(ObstacleType));

    // Method to shuffle an array
    private void ShuffleArray<T>(T[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            // Randomly pick an element that has not been shuffled yet
            int randomIndex = i + Random.Range(0, n - i);
            // Swap the picked element with the current element
            (array[randomIndex], array[i]) = (array[i], array[randomIndex]);
        }
    }

    private ObstacleType GenerateObstacleType()
    {
        return types[Random.Range(0, types.Length)];
    }
    private ObstacleType[] GenerateObstacleLine()
    {
        // these will be the 3 obstacles in a line from left to right, put at least one cone on the left, shuffle them after
        ObstacleType[] obstacleLine = new ObstacleType[3];
        int coneNumber = Random.Range(1, 3);
        if (coneNumber == 1)
        {
            obstacleLine[0] = ObstacleType.Cone;
        }
        else
        {
            obstacleLine[0] = ObstacleType.BigCone;
        }
        obstacleLine[1] = GenerateObstacleType();
        obstacleLine[2] = GenerateObstacleType();
        ShuffleArray(obstacleLine);
        return obstacleLine;
    }
    // Start is called before the first frame update
    void Start()
    {
        // randomly generate the initial platform, there should be at least one cone on every platform
        for (int a = 0; a < 10; a++)
        {
            ObstacleType[] obstacleLine = GenerateObstacleLine();
            Instantiate(obstaclePrefabs[(int)obstacleLine[0]], new Vector3(-4, 0.1f, 13 + a * 20), Quaternion.identity).transform.Rotate(0, 90, 0);
            Instantiate(obstaclePrefabs[(int)obstacleLine[1]], new Vector3(0, 0.1f, 13 + a * 20), Quaternion.identity).transform.Rotate(0, 90, 0);
            Instantiate(obstaclePrefabs[(int)obstacleLine[2]], new Vector3(4, 0.1f, 13 + a * 20), Quaternion.identity).transform.Rotate(0, 90, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
