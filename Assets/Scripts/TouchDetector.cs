using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Bolt;

public class TouchDetector : Bolt.EntityBehaviour<ISphereState>
{
    public GameObject line;
    //public Text text;
    public Camera fpsCam;
    public Vector3 camTrans;

    public void FixedUpdate()
    {
        
        if (Input.touchCount>0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Vector3 touch = Input.GetTouch(i).position;
                touch.z = 4.0f;

                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {                    
                    camTrans = fpsCam.ScreenToWorldPoint(touch);
                    BoltNetwork.Instantiate(line, camTrans, Quaternion.identity);
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Moved)
                {
                    camTrans = fpsCam.ScreenToWorldPoint(touch);
                    BoltNetwork.Instantiate(line, camTrans, Quaternion.identity);
                }             
            }
        }
    }
}
