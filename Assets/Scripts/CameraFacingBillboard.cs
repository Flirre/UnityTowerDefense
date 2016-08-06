//credit where credit is due. http://wiki.unity3d.com/index.php?title=CameraFacingBillboard
using UnityEngine;
using System.Collections;
using System;

public class CameraFacingBillboard : MonoBehaviour
{
    public Camera m_Camera;
    String objTag;
    float scalar = 0;

    void Start()
    {
        m_Camera = Camera.main;
        objTag = gameObject.tag.ToString();
    }

    

    void Update()
    {
        paintHealthBar(objTag);
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.left,
            m_Camera.transform.rotation * Vector3.up);
    }


    void paintHealthBar(string s)
    {
        if (s == "EnemyHealth")
        {
            scalar = (float)gameObject.transform.parent.GetComponent<Enemy>().health / 100;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, scalar * 6); // 6 is a magic number, which comes from the z-scale for the healthbar.
        }

        if(s == "DefenseHealth")
        {

            scalar = (float)gameObject.transform.parent.GetComponent<Base>().health / 150;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, scalar * 3); // 3 is a magic number, which comes from the z-scale for the healthbar.

        }
        if(s == "TowerHealth")
        {
            scalar = (float)gameObject.transform.parent.GetComponent<Tower>().health / 100;
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y, scalar * 3); // 6 is a magic number, which comes from the z-scale for the healthbar.
        }
    }
}

