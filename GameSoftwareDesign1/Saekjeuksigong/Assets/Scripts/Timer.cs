using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    public int initialTime;
    public float timeLeft;
    public Text timeShower;
   
    public GameObject timeOverPanel;
    public GameObject ball;

	// Use this for initialization
	void Start () {

        timeLeft = initialTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        timeShower.text = "Time Left:" + (int)timeLeft;
        if (timeLeft <= 0)
        {
            ball.SetActive(false);
            timeOverPanel.SetActive(true);
            
        }
    }
}
