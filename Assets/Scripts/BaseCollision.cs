using UnityEngine;
using System.Collections;

public class BaseCollision : MonoBehaviour {


    void OnCollisionEnter(Collision collisionInfo)
    {
        Base b = gameObject.GetComponent<Base>();
        if (collisionInfo.collider.tag == "Enemy Missile")
        {
            print(b.health);
            b.health = b.health - 5;
            print(b.health);
        }
        if (b.health <= 0)
        {
            GameObject endScreen = GameObject.Find("EndScreen");
            endScreen.GetComponent<EndScreen>().Show();
            GameObject enemiesDestroyed = GameObject.Find("Enemies Destroyed");
            enemiesDestroyed.GetComponent<UI>().Hide();
            Destroy(gameObject);
            Time.timeScale = 0;


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
