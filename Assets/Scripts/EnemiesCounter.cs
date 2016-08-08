using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemiesCounter : MonoBehaviour {

    Text text;
    // Use this for initialization
    void Awake()
    {
        //EnemySpawn e = gameObject.GetComponent<EnemySpawn>();
        text = GetComponent<Text>();
        //if first map - left here if I someday expand the game.

        //starting money.

    }

    // Update is called once per frame
    void Update()
    {
        int enemies = EnemyCollision.enemiesDestroyed;

        text.text = "Enemies destroyed: " + enemies;
    }
}
