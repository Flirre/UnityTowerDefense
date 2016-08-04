﻿using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    Transform target;

    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {
            Enemy e = gameObject.GetComponent<Enemy>();
            print(e.health);
            e.health = e.health - 10;
            print(e.health);
            if (e.health <= 0)
            {
                CashHandler.cash = CashHandler.cash += 50;
                Destroy(gameObject);
            }
        }
        else if (collisionInfo.collider.tag == "Enemy")
        {
            Enemy e = gameObject.GetComponent<Enemy>();
            print(gameObject.GetComponent<Enemy>().stopped);
            e.stopped = true;
        }

    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {

        }
        else if (collisionInfo.collider.tag == "Enemy")
        {
            Enemy e = gameObject.GetComponent<Enemy>();
            e.stopped = true;
        }
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");

    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {

        }
        else if (collisionInfo.collider.tag == "Enemy")
        {
            Enemy e = gameObject.GetComponent<Enemy>();
            e.stopped = false;
        }
        print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
       // e.stopped = false;
    }
}