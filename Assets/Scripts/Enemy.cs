using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    GameObject walkPath;
    Transform targetNode;
    int nodeIndex = 0;
    float speed = 100;

	// Use this for initialization
	void Start () {
        walkPath = GameObject.Find("WalkPath");
	}
	
	// Update is called once per frame
	void Update () {
        if(targetNode == null)
        {
            GetNextNode();
            if(targetNode == null)
            {
                //if(noCollide(otherEnemy))
                //Attack(Base);
            }
        }

        Vector3 direction = targetNode.position - this.transform.localPosition;

        float rangeThisFrame = speed * Time.deltaTime;

        if(direction.magnitude <= rangeThisFrame)
        {
            //node reached
            targetNode = null;

        }

        else
        {//move to targetNode
            transform.Translate(direction.normalized * rangeThisFrame, Space.World);
            this.transform.rotation = Quaternion.LookRotation(direction); //makes the enemy look toward node they are approaching.

        }
	
	}

    void GetNextNode() {
        targetNode = walkPath.transform.GetChild(nodeIndex);
        nodeIndex++;
    }

    void Attack()
    {

    }
}
