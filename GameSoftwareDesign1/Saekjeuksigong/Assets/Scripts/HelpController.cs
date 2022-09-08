using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpController : MonoBehaviour {
	public void OnBackToMenuButtonClicked(){
		SceneManager.LoadScene ("Menu");
		SceneManager.UnloadSceneAsync ("Help");
	}
}
