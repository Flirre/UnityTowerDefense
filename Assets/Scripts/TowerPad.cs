using UnityEngine;
using System.Collections;

public class TowerPad : MonoBehaviour {

    bool pressed = false;
    public bool towerOnPad = false;

    void Update()
    {

        if ((pressed == true) & (towerOnPad == false))
        {
            //Debug.Log("PRESSED");
            Tower tower = (Tower)Instantiate(Resources.Load("Tower"), transform.position + new Vector3(0,38,0), Quaternion.identity);
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
