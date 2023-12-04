using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject platform;
    public GameObject mainCamera;
    readonly float carSpeed = 10f;

    // move a GameObject forward by the car's speed
    void Forward(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(0, 0, carSpeed * Time.deltaTime);
    }

    void Left(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(-carSpeed * Time.deltaTime, 0, 0);
    }

    void Right(GameObject gameObject)
    {
        gameObject.transform.position += new Vector3(carSpeed * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
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
}
