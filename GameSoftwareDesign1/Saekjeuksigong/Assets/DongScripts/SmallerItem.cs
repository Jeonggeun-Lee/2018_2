using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallerItem : MonoBehaviour {

    public Vector3 rotatePerSec;
    private Vector3 rotatePerFrame;
    public float Sscale;

    

    void Start()
    {
        rotatePerFrame = rotatePerSec * Time.fixedDeltaTime;
        
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            
            other.gameObject.transform.localScale = new Vector3(Sscale, Sscale, Sscale);
            Destroy(gameObject);


        }
       
    }

    void FixedUpdate()
    {
        transform.Rotate(rotatePerFrame);
    }
}
