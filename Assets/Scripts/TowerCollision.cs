using UnityEngine;
using System.Collections;


public class TowerCollision : MonoBehaviour {
    GameObject tower;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("MISSILE SHOT");
            Instantiate(Resources.Load("missilePrefab"), this.transform.position, Quaternion.identity);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
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