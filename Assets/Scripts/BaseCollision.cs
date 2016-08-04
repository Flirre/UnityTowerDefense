using UnityEngine;
using System.Collections;

public class BaseCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
        Base b = gameObject.GetComponent<Base>();
        print(b.health);
        b.health = b.health - 10;
        print(b.health);
        if (b.health <= 0)
        {
            Destroy(gameObject);
        }
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
