//Credit to this thread. http://answers.unity3d.com/questions/352235/moving-camera-with-wasd.html
using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
    float zAxisValue = 0;

    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal");
        if (Input.mouseScrollDelta.y > 0) {
            zAxisValue = 1;
                }
        else if (Input.mouseScrollDelta.y < 0)
        {
            zAxisValue = -1;
        }

        //print("x axis:" + xAxisValue);
        //print("z axis:" + zAxisValue);
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
        }
        if(zAxisValue > 0)
        {
            zAxisValue =  zAxisValue - (float) 0.05;
        }

        if (zAxisValue < 0)
        {
            zAxisValue = zAxisValue + (float) 0.05;
        }
    }
}