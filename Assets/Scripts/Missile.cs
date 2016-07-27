using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    GameObject target = null;
    void FixedUpdate()
    {
        if(target == null)
        {
            target = getClosestEnemy();
        }
        //Lock on and follow til impact.
    }

    GameObject getClosestEnemy()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        float dist = Mathf.Infinity;
        Vector3 pos = transform.position;
        foreach(GameObject e in enemies)
        {
            Vector3 diff = e.transform.position - pos;
            float currentDist = diff.sqrMagnitude;
            if(currentDist < dist)
            {
                target = e;
                dist = currentDist;
            }

        }


        return target;
    }

}
