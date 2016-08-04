using UnityEngine;
using System.Collections;

public class EnemySpawnTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            EnemySpawn.enemyOnSpawn = true;
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            EnemySpawn.enemyOnSpawn = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            EnemySpawn.enemyOnSpawn = false;
        }
    }

}