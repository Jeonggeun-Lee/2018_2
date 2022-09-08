using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoController : MonoBehaviour {

    public float waitingTime = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        waitingTime -= Time.deltaTime;
        if (waitingTime < 0)
        {
            SceneManager.LoadScene("Menu");
            SceneManager.UnloadSceneAsync("Logo");
        }
	}
}
