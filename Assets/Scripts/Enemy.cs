using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    GameObject walkPath;
    Transform targetNode;
    int nodeIndex = 0;

	// Use this for initialization
	void Start () {
        walkPath = GameObject.Find("WalkPath");

	}
	
	// Update is called once per frame
	void Update () {
        if(targetNode == null)
        {
            getNextNode();
            if(targetNode == null)
            {
                //if(noCollide(otherEnemy))
                baseAttack();
            }
        }
	
	}

    void getNextNode() {
        targetNode = walkPath.transform.GetChild(nodeIndex);
        nodeIndex++;
    }

    void baseAttack()
    {

    }
}
