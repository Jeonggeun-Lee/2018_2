using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerItem : MonoBehaviour {

    public Vector3 rotatePerSec;
    private Vector3 rotatePerFrame;
    public float Bscale;
    

    void Start()
    {
        rotatePerFrame = rotatePerSec * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.transform.localScale = new Vector3(Bscale, Bscale, Bscale);
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Rotate(rotatePerFrame);
    }
}
