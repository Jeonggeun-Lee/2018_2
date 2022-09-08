using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour {

	public GameObject whiteHole;
	void Update(){
		
	}
	void OnTriggerEnter( Collider other){
        if (other.CompareTag("Ball"))
        {
            other.transform.position = whiteHole.transform.position;
        }
		
	}
}
