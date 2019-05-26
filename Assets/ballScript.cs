using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour
{
    float XTilt = 90f;
    float YTilt = 0f;
    public GameObject spawnPoint;
    public Camera CameraRotation;


    public float MovementSpeed;
    float yRotation = 90f;
    float xRotation = 0f;
    float SphereZ;
    float SphereX;
    float SphereY;


    private void Update()
    {
        float SphereY = GameObject.Find("Sphere").transform.position.y;
        float SphereX = GameObject.Find("Sphere").transform.position.z;
        float SphereZ = GameObject.Find("Sphere").transform.position.x;
        float yRotation = CameraRotation.transform.localRotation.eulerAngles.y;
        float xRotation = CameraRotation.transform.localRotation.eulerAngles.x;

        if (xRotation <= XTilt)
        {
            print(XTilt+"Tilted -x moving up" + xRotation);
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        else if (xRotation >= XTilt)
        {
            print(XTilt+"Tilted -x moving down" + xRotation);
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
        }

        else 
        {
            print(" -x not moving");
        }

        if (yRotation <= YTilt)
        {
            print(YTilt+"Tilted -y moving right" + yRotation);
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else if (yRotation >= YTilt)
        {
            print(YTilt+"Tilted -y moving left" + yRotation);
            transform.Translate(-Vector3.back * MovementSpeed * Time.deltaTime);
        }

        else
        {
            print(" -y not moving");
        }

        if (SphereY <= -1 || SphereY >= 1 || SphereX <= -1 || SphereX >= 1 || SphereZ <= -1 || SphereZ >= 1)
        {
            transform.position = spawnPoint.transform.position;
        }
    }

    void OnTriggerEnter(Collider Other)
    {

        if (Other.gameObject.tag == "Respawn")
        {
            transform.position = spawnPoint.transform.position;
        }
        
    }
}