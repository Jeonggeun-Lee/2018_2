using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EditorController : MonoBehaviour {
	public void OnBackToMenuButtonClicked(){
		SceneManager.LoadScene ("Menu");
		SceneManager.UnloadSceneAsync ("Editor");
	}

}
