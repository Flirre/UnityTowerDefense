using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    GameObject target = null;
    Transform targetEnemy = null;
    float speed = 100;


    void FixedUpdate()
    {
        float rangeThisFrame = speed * Time.deltaTime;
        if (target == null)
        {
            target = getClosestEnemy();
        }
        else
        {
            targetEnemy = target.transform;
            Vector3 direction = targetEnemy.position - transform.localPosition;
            transform.Translate(direction.normalized * rangeThisFrame, Space.World);
            if (target == null)
                Destroy(gameObject);
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
