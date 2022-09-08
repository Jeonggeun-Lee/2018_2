using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MunuController : MonoBehaviour {

	public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("StageSelection");
        SceneManager.UnloadSceneAsync("Menu");
    }

    public void OnHelpButtonClicked()
    {
		SceneManager.LoadScene("Help");
		SceneManager.UnloadSceneAsync("Menu");
    }

    public void OnEditorButtonClicked()
    {
		SceneManager.LoadScene("Editor");
		SceneManager.UnloadSceneAsync("Menu");
    }
}
