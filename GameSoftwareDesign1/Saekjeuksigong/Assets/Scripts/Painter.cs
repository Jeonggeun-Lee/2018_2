using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            other.gameObject.GetComponent<MeshRenderer>().material.color = GetComponent<MeshRenderer>().material.color;
        }
    }
}
