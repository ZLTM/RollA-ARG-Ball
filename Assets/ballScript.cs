using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour
{
    public float XTilt = 90f;
    public float NewXTilt;
    public float YTilt = 0f;
    public float NewYTilt;
    public GameObject spawnPoint;
    public Camera CameraRotation;


    public float MovementSpeed;
    float yRotation = 90f;
    float xRotation = 0f;

    public void Start()
    {
        float yRotation = CameraRotation.transform.rotation.y;
        float xRotation = CameraRotation.transform.rotation.x;
    }

    private void Update()
    {
        if (CameraRotation.transform.eulerAngles.x <= XTilt)
        {
            print(XTilt+"Tilted -x moving up" + CameraRotation.transform.rotation.x);
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else if (CameraRotation.transform.eulerAngles.x >= XTilt)
        {
            print(XTilt+"Tilted -x moving down" + CameraRotation.transform.rotation.x);
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else 
        {
            print(" -x not moving");
        }

        if (CameraRotation.transform.eulerAngles.y <= YTilt)
        {
            print(YTilt+"Tilted -y moving right" + CameraRotation.transform.rotation.y);
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        else if (CameraRotation.transform.eulerAngles.y >= YTilt)
        {
            print(YTilt+"Tilted -y moving left" + CameraRotation.transform.rotation.y);
            transform.Translate(-Vector3.right * MovementSpeed * Time.deltaTime);
        }

        else
        {
            print(" -y not moving");
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