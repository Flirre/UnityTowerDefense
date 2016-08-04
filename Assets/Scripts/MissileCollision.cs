using UnityEngine;
using System.Collections;

public class MissileCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
       // print("BEFORE IF");
        if(collisionInfo.collider.tag == "Enemy")
        {
      //      print("IN IF");
            Destroy(gameObject);
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
        print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
}
