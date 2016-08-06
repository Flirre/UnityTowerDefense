﻿using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    public static int enemiesLeft = 10;
    float waitTime = 0;
    public static bool enemyOnSpawn = false;

    void Update () {
        // print(enemiesLeft);
        // print(waitTime);
        // print((enemiesLeft > 0) && (waitTime == 0));
        //print(enemyOnSpawn);
        if ((enemiesLeft > 0) && (waitTime == 0) && (enemyOnSpawn == false))
        {
            //Debug.Log("SPAWN CAR");
            Instantiate(Resources.Load("Enemy"), transform.position, Quaternion.identity);
            waitTime = 100;
            enemiesLeft--;
        }
        if(waitTime >= 0)
        waitTime--;
        if (waitTime < 0)
            waitTime = 0;
    }
}
