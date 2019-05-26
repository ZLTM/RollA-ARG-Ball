using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour
{
    float XBegin;
    float ZBegin;
    public GameObject spawnPoint;
    public Camera CameraPosition;


    public float MovementSpeed;
    float ZPosition = 0f;
    float XPosition = 0f;
    float SphereZ;
    float SphereX;

    private void Start()
    {
        float XBegin = CameraPosition.transform.position.z;
        float ZBegin = CameraPosition.transform.position.x;
    }

    private void Update()
    {
        float SphereZ = GameObject.Find("Sphere").transform.position.z;
        float SphereX = GameObject.Find("Sphere").transform.position.z;
        float ZPosition = CameraPosition.transform.position.z;
        float XPosition = CameraPosition.transform.position.x;

        if (XPosition <= XBegin)
        {
            print(XBegin + "Tilted -x moving right" + XPosition);
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        else if (XPosition >= XBegin)
        {
            print(XBegin + "Tilted -x moving left" + XPosition);
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
        }

        else 
        {
            print(" -x not moving");
        }

        if (ZPosition <= ZBegin)
        {
            print(ZBegin + "Tilted -z moving up" + ZPosition);
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else if (ZPosition >= ZBegin)
        {
            print(ZBegin + "Tilted -z moving down" + ZPosition);
            transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);
        }

        else
        {
            print(" -z not moving");
        }

        if (SphereZ <= -1 || SphereZ >= 1 || SphereX <= -1 || SphereX >= 1 || SphereZ <= -1 || SphereZ >= 1)
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