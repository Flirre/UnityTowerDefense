using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashHandler : MonoBehaviour {
    public static int cash;

    Text text;
    // Use this for initialization
    void Awake () {
        text = GetComponent<Text>();
        //if first map - left here if I someday expand the game.

        //starting money.
        cash = 500;
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Cash: " + cash;
	
	}
}
