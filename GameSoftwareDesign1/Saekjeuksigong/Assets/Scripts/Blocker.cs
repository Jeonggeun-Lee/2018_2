using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            if(other.gameObject.GetComponent<MeshRenderer>().material.color == GetComponent<MeshRenderer>().material.color)
            {
                other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.GetComponent<Rigidbody>().velocity.normalized * (-1200));
            }
        }
    }
}
