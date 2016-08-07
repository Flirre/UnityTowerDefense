using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {
    string tower;
    


    public void towerBuyButton()
    {
        tower = gameObject.name;
        //print(tower);
        if ( ((tower.Equals("Tower1")) && (CashHandler.cash > 99)) || ((tower.Equals("Tower2") && (CashHandler.cash > 199))) )
        {
            gameObject.transform.parent.parent.parent.GetComponent<TowerPad>().buyTower(tower);
        }
        gameObject.transform.parent.parent.GetComponent<UI>().Hide();

    }

}
