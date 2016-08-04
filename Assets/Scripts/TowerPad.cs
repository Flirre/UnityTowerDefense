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
            Instantiate(Resources.Load("Tower"), transform.position + new Vector3(0,38,0), Quaternion.identity);
            print(transform.position);
            CashHandler.cash -= 100;
            towerOnPad = true;
        }
    }

    void OnMouseDown()
    {
        pressed = true;
    }

    void OnMouseUp()
    {
        pressed = false;
    }

}
