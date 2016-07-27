using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{

    
    void OnCollisionEnter(Collision collisionInfo)
    {
        Enemy e = gameObject.GetComponent<Enemy>();
        print(e.health);
        e.health = e.health - 10;
        print(e.health);
        if(e.health <= 0)
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