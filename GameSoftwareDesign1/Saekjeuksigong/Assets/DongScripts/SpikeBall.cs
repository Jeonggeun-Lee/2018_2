using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeBall : MonoBehaviour {
    Rigidbody rb;
    public GameObject player;

    public UIController ui;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Ball"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update() {
        
    }
    
}
