using UnityEngine;
using System.Collections;

public class MissileCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
        // print("BEFORE IF");
        if (gameObject.tag == "Missile")
        {
            if (collisionInfo.collider.tag == "Enemy")
            {
                //      print("IN IF");
                Destroy(gameObject);
            }
        }

        else if(gameObject.tag == "Enemy Missile")
        {
            //print("WOOOOOOOOOOO");
            //print(collisionInfo.collider.tag);
            //print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
            if (collisionInfo.collider.tag == "Defense")
            {
                print("kapow");
                Destroy(gameObject);
            }
        }
     //   print("AFTER IF");
        //print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");

    }

    void OnCollisionExit(Collision collisionInfo)
    {
       // print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding. missile colission.css");
    }
}
