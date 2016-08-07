using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    public static int enemiesLeft = 25;
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
            if ((Random.Range(0, 10)) > 5)
            {
                Instantiate(Resources.Load("Enemy"), transform.position, Quaternion.identity);
            }
            else
            {
               GameObject enemy = Instantiate(Resources.Load("Enemy 1"), transform.position, Quaternion.identity) as GameObject;
                enemy.GetComponent<Enemy>().speed = 150;
                enemy.GetComponent<Enemy>().health = 70;
            }
            waitTime = 100;
            enemiesLeft--;
        }
        if(waitTime >= 0)
        waitTime--;
        if (waitTime < 0)
            waitTime = 0;
    }
}
