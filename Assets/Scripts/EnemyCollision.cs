using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour
{
    Transform target;
    int cooldown = 0;
    
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
        //print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
       //e.stopped = false;
    }

    void OnTriggerEnter(Collider other)
    {
        Enemy e = gameObject.GetComponent<Enemy>();

        if ((other.tag == "Defense") || (other.tag == "Base"))  
        {
            print("SPOTTED DEFENSE");
        }

    }

    void OnTriggerStay(Collider other)
    {
        Enemy e = gameObject.GetComponent<Enemy>();
        if ((other.tag == "Defense") || (other.tag == "Base"))
        {
            if(cooldown == 0)
            {
                //print("pewpew");
                Instantiate(Resources.Load("Missile2Prefab"), transform.position + new Vector3(0, 10, 0), Quaternion.identity);
                cooldown = 100;
            }
            cooldown--;
            //print("STILL SPOTTING DEFENSE");
        }

    }

    void OnTriggerExit(Collider other)
    {
        Enemy e = gameObject.GetComponent<Enemy>();
        //print("LOST IT");

    }

}