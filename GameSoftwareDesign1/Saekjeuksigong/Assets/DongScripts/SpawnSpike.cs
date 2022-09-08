using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpike : MonoBehaviour {

    public GameObject Spikeball;

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            Spikeball.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
