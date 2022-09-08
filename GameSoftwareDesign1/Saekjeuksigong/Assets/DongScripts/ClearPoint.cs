using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearPoint : MonoBehaviour {
    UIController ui;

    public Image next;
    
    public int nextScene;
    bool isClear;

    public void Start()
    {
        
        //클리어 여부
        isClear = false;
        
        nextScene = SceneManager.GetActiveScene().buildIndex+1;
        
    }

    public void OnTriggerEnter(Collider other)
    {
        isClear = true;
        if (other.tag.Equals("Ball"))
        {
            next.gameObject.SetActive(true);
            
        }
       
    }

    // Update is called once per frame
    void Update () {
        
    }
}
