using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDAndL2Rer : MonoBehaviour {

    public RollerBall rollerBall;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball")
        { 

            rollerBall.leftToRight = true;
            rollerBall.upsideDown = true;
        }
    }

}
