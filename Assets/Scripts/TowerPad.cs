using UnityEngine;
using System.Collections;

public class TowerPad : MonoBehaviour {

    bool pressed = false;
    public bool towerOnPad = false;
    //string towerToSpawn;


    void Start()
    {

    }
    void Update()
    {

    }

    void OnMouseDown()
    {
        pressed = true;
    }

    public void buyTower(string towerToSpawn)
    {
        CashHandler.subtract(towerToSpawn);
        if (towerToSpawn.Equals("Tower1"))
        {
            GameObject tower = Instantiate(Resources.Load("Tower"), transform.position + new Vector3(0, 38, 0), Quaternion.identity) as GameObject;

        }

        if (towerToSpawn.Equals("Tower2"))
        {
            GameObject tower = Instantiate(Resources.Load("Tower2"), transform.position + new Vector3(0, 38, 0), Quaternion.identity) as GameObject;
            tower.GetComponent<Tower>().health = 200;
            tower.GetComponent<Tower>().MaxCooldown = 40;

        }

    }


void OnMouseUp()
{
        Debug.Log("HELLO");
        UI canvas = gameObject.GetComponentInChildren<UI>();
        if (canvas.visible)
        {
            canvas.Hide();
        }
        else
        {
            canvas.Show();
        }
}


}
