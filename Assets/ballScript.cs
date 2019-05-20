using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour
{
    public float XTilt = 90f;
    public float NewXTilt;
    public float YTilt = 0f;
    public float NewYTilt;
    public GameObject spawnPoint;

    public float MovementSpeed;

    private void Update()
    {

        if (NewXTilt <= XTilt)
        {
            print("Tilted -z moving up");
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else if (NewXTilt >= XTilt)
        {
            print("Tilted -z moving down");
            transform.Translate(-Vector3.forward * MovementSpeed * Time.deltaTime);
        }

        else 
        {
            print(" -z not moving");
        }

        if (NewYTilt <= YTilt)
        {
            print("Tilted -x moving right");
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }

        else if (NewYTilt >= YTilt)
        {
            print("Tilted -x moving left");
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
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