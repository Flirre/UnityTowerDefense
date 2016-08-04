using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    Transform target;

    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {
            Enemy e = gameObject.GetComponent<Enemy>();
         //   print(e.health);
            e.health = e.health - 10;
          //  print(e.health);
            if (e.health <= 0)
            {
                CashHandler.cash = CashHandler.cash += 50;
                Destroy(gameObject);
            }
        }

    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {

        }
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");

    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Missile")
        {

        }
        print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
       //e.stopped = false;
    }

}