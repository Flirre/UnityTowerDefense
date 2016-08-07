using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    GameObject walkPath;
    GameObject targetBase;
    Transform targetNode;
    int numberOfNodes = 0;
    int nodeIndex = 0;
    public int health = 100;
    float speed = 100;
    public bool stopped = false;


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
            //Debug.Log(nodeIndex);
            if(targetNode == null)
            {
                //if(noCollide(otherEnemy))
                Debug.Log("Base");
                targetNode = targetBase.transform;
                print(health);
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
            if (!stopped) {
                transform.Translate(direction.normalized * rangeThisFrame, Space.World);
                Quaternion goalRotation = Quaternion.LookRotation(direction);
                this.transform.rotation = Quaternion.Lerp(this.transform.rotation, goalRotation, 20 * Time.deltaTime);  //makes the enemy gradually look towards the node they are approaching.

            }
            else if(stopped)
            {
                gameObject.transform.Translate(new Vector3(0,0,0), Space.Self);
                nodeIndex--;
                //print("node minus");
                GetNextNode();
                if (!stopped)
                {
                    print("help, im in a if");
                }

            }
        }
	
	}

    void GetNextNode() {
        targetNode = walkPath.transform.GetChild(nodeIndex);
        if (numberOfNodes > nodeIndex + 1)
        {
            nodeIndex++;
        }
        else
        {
            //Debug at end of the map.
        }
    }
}
