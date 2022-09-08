using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalChecker : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Ball") {
			SceneManager.LoadScene ("StageSelection");
            SceneManager.UnloadSceneAsync("Stage1");
        }
	}
}
