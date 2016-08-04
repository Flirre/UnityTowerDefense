using UnityEngine;
using System.Collections;

public class EnemyToEnemyTriggerCollision : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        Enemy e = gameObject.transform.parent.GetComponent<Enemy>();
        
        if (other.tag == "Enemy")
        {
            e.stopped = true;
            print("IN");
        }
        
    }

    void OnTriggerStay(Collider other)
    {
        Enemy e = gameObject.transform.parent.GetComponent<Enemy>();
        if (other.tag == "Enemy")
        {
            e.stopped = true;
            print("STILL IN");
        }

    }

    void OnTriggerExit(Collider other)
    {
        Enemy e = gameObject.transform.parent.GetComponent<Enemy>();
        e.stopped = false;
        print("OUT");

    }
}
