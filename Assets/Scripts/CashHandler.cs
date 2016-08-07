using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashHandler : MonoBehaviour {
    public static int cash;
    //write in different costs for different towers so it can be accessed by buttons etc.

    Text text;
    // Use this for initialization
    void Awake () {
        text = GetComponent<Text>();
        //if first map - left here if I someday expand the game.

        //starting money.
        cash = 500;
	}

    public static void subtract(string towerName)
    {
        print(towerName);
        if(towerName.Equals("Tower1"))
        {
            cash = cash - 100;
        }
        else if(towerName == "Tower2")
        {
            cash = cash - 200;
        }
    }


    /*
    public static void add()
    {

    }
	*/


	// Update is called once per frame
	void Update () {
        text.text = "Cash: " + cash;
	
	}
}
