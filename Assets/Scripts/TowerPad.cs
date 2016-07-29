using UnityEngine;
using System.Collections;

public class TowerPad : MonoBehaviour {

    bool pressed = false;
    bool towerOnPad = false;

    void Update()
    {

        if ((pressed == true) & (towerOnPad == false))
        {
            Debug.Log("PRESSED");
            Instantiate(Resources.Load("Tower"), transform.position, Quaternion.identity);
            towerOnPad = true;
        }
    }

    void OnMouseDown()
    {
        Debug.Log("DOWN");
        pressed = true;
    }

    void OnMouseUp()
    {
        Debug.Log("UP");
        pressed = false;
    }

}
