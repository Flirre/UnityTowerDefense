using UnityEngine;
using System.Collections;

public class TowerPad : MonoBehaviour {

    bool pressed = false;
    public bool towerOnPad = false;
    //string towerToSpawn;

    void Update()
    {

    }

    void OnMouseDown()
    {
        pressed = true;
    }

    void buyTower(string towerToSpawn)
    {
        if (towerToSpawn.Equals("Tower1"))
        {
            Tower tower = (Tower)Instantiate(Resources.Load("Tower"), transform.position + new Vector3(0, 38, 0), Quaternion.identity);
            CashHandler.cash -= 100;
        }
        if (towerToSpawn.Equals("Tower2"))
        {
            Tower tower = (Tower)Instantiate(Resources.Load("Tower2"), transform.position + new Vector3(0, 38, 0), Quaternion.identity);
            CashHandler.cash -= 200;
        }

    }


void OnMouseUp()
{

}


}
