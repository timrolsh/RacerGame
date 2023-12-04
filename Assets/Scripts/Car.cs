using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public Canvas deathScreen;
    private ScoreManager _scoreManager = ScoreManager.Instance;
    public GameObject platform;
    public GameObject mainCamera;
    public bool isActive = true;

    readonly float carSpeed = 10f;

    // move a GameObject forward by the car's speed
    void Forward(GameObject go)
    {
        go.transform.position += new Vector3(0, 0, carSpeed * Time.deltaTime);
    }

    void Left(GameObject go)
    {
        go.transform.position += new Vector3(-carSpeed * Time.deltaTime, 0, 0);
    }

    void Right(GameObject go)
    {
        go.transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
    }

    void Start()
    {
        _scoreManager = ScoreManager.Instance;
        _scoreManager.StartScore();
        deathScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {

            Forward(gameObject);
            // once the car has moved past the initial platform, start to move the main platform it will be on
            if (gameObject.transform.position.z > 12)
            {
                Forward(platform);

            }
            Forward(mainCamera);

            // allow the car to strafe left and right based on users input
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                Left(gameObject);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                Right(gameObject);
            }
        }
        else
        {
            deathScreen.enabled = true;
        }
    }
}
