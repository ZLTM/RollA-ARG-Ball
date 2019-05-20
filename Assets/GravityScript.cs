using UnityEngine;
using System.Collections;

public class GravityScript : MonoBehaviour
{

    public float grav = 380;

    // Use this for initialization
    void Start()
    {
        //CameraDevice.Instance.StopAutoFocus();
        if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        {
            Debug.Log("LEFT");

        }
        else if (Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            Debug.Log("RIGHT");
        }
        else if (Screen.orientation == ScreenOrientation.Portrait)
        {
            Debug.Log("PORTRAIT");
        }
    }

    void FixedUpdate()
    {

        //CameraDevice.Instance.StopAutoFocus();
        /*if (Screen.orientation == ScreenOrientation.LandscapeLeft) {
			Physics.gravity = new Vector3 (Input.acceleration.y * grav , -Input.acceleration.x * grav , -Input.acceleration.z * grav);
		} else if (Screen.orientation == ScreenOrientation.LandscapeRight ) {
			Physics.gravity = new Vector3 (-Input.acceleration.y * grav , Input.acceleration.x * grav , -Input.acceleration.z * grav);
		} else if (Screen.orientation == ScreenOrientation.Portrait ) {*/
        Physics.gravity = new Vector3(Input.acceleration.x * grav, Input.acceleration.y * grav, -Input.acceleration.z * grav);
        //}
    }
}
