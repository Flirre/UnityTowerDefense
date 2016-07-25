using UnityEngine;
using System.Collections;

public class TowerCollision : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        print("Collision detected with trigger object " + other.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("Still colliding with trigger object " + other.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(gameObject.name + " and trigger object " + other.name + " are no longer colliding");
    }



}


// Collisions found in this tutorial https://www.binpress.com/tutorial/unity-3d-collisions-basics/114