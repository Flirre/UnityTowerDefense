using UnityEngine;
using System.Collections;


public class TowerCollision : MonoBehaviour {
    int cooldown = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {

        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            if (cooldown <= 0)
            {
                //Debug.Log("MISSILE SHOT");
                Instantiate(Resources.Load("missile1Prefab"), transform.position + new Vector3(0,30,0), Quaternion.identity);
                GetComponent<AudioSource>().Play(1);
                cooldown = gameObject.GetComponent<Tower>().MaxCooldown;
            }
            cooldown--;
            //print("Still colliding with trigger object " + other.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //print(gameObject.name + " and trigger object " + other.name + " are no longer colliding");
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Tower t = gameObject.GetComponent<Tower>();

        if (collisionInfo.collider.tag == "Enemy Missile")
        {
            print(t.health);
            t.health = t.health - 2;
            print(t.health);
        }
        if (t != null) //added because I got a bunch of NREs.
        {
            if (t.health < 1)
            {
                Destroy(gameObject);
            }
        }
            //print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);

    }

    void OnCollisionStay(Collision collisionInfo)
    {
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");

    }

    void OnCollisionExit(Collision collisionInfo)
    {
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }

}


// Collisions found in this tutorial https://www.binpress.com/tutorial/unity-3d-collisions-basics/114