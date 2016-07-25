using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    GameObject walkPath;
    GameObject targetBase;
    Transform targetNode;
    int numberOfNodes = 0;
    int nodeIndex = 0;
    float speed = 100;


    // Use this for initialization
    void Start () {
        walkPath = GameObject.Find("WalkPath");
        targetBase = GameObject.Find("Base");
        numberOfNodes = walkPath.transform.childCount;
	}
	
	// Update is called once per frame
	void Update () {
        if(targetNode == null)
        {
            GetNextNode();
            Debug.Log(nodeIndex);
            if(targetNode == null)
            {
                //if(noCollide(otherEnemy))
                Debug.Log("Base");
                targetNode = targetBase.transform;
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
            Quaternion goalRotation = Quaternion.LookRotation(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, goalRotation, 20 * Time.deltaTime);  //makes the enemy gradually look towards the node they are approaching.

        }
	
	}

    void GetNextNode() {
        targetNode = walkPath.transform.GetChild(nodeIndex);
        if (numberOfNodes > nodeIndex + 1)
        {
            nodeIndex++;
        }
    }

    void Attack()
    {

    }
}
