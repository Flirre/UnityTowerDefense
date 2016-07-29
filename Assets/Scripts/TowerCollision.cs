using UnityEngine;
using System.Collections;


public class TowerCollision : MonoBehaviour {
    GameObject tower;
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
            if (cooldown == 0)
            {
                Debug.Log("MISSILE SHOT");
                Instantiate(Resources.Load("missilePrefab"), transform.position, Quaternion.identity);
                cooldown = 100;
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



}


// Collisions found in this tutorial https://www.binpress.com/tutorial/unity-3d-collisions-basics/114