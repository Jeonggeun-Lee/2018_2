using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void Nextstage(int value)
    {
        Debug.Log(0);
        SceneManager.LoadScene(value);
    }
    // Update is called once per frame
    
}
