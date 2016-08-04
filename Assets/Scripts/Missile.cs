using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    GameObject target = null;
    Transform targetEnemy = null;
    int speed = 150;
    string targetName;


    void FixedUpdate()
    {
        float rangeThisFrame = speed * Time.deltaTime;
        if (target == null)
        {
            if (gameObject.tag == "Missile")
            {
                target = getClosest("Enemy");
            }
            else if (gameObject.tag == "Enemy Missile")
            {
                if(getClosest("Defense") != null)
                target = getClosest("Defense");
            }
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

    GameObject getClosest(string s)
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag(s);

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
