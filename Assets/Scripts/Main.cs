using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject platform;
    public GameObject mainCamera;
    float carSpeed = 10f;
    void Start()
    {


    }

    // move a GameObject forward by the car's speed
    void forward(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(0, 0, carSpeed * Time.deltaTime);
    }

    void left(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(-carSpeed * Time.deltaTime, 0, 0);
    }

    void right(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        forward(gameObject);
        // once the car has moved past the initial platform, start to move the main platform it will be on
        if (gameObject.transform.position.z > 12)
        {
            forward(platform);
        }
        forward(mainCamera);

        // allow the car to strafe left and right based on users input
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            left(gameObject);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            right(gameObject);
        }
    }
}
