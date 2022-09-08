using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectionController : MonoBehaviour {

    public void OnBackToMenuButtonClicked()
    {
        SceneManager.LoadScene("Menu");
        SceneManager.UnloadSceneAsync("StageSelection");
    }

    public void OnStage1ButtonClicked(){
        
		SceneManager.LoadScene ("Stage1");
        SceneManager.UnloadSceneAsync("StageSelection");
	}

	public void OnStage2ButtonClicked(){
		SceneManager.LoadScene ("Stage2");
        SceneManager.UnloadSceneAsync("StageSelection");
    }

	public void OnStage3ButtonClicked(){
		SceneManager.LoadScene ("Stage3");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage4ButtonClicked()
    {
        SceneManager.LoadScene("Stage4");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage5ButtonClicked()
    {
        SceneManager.LoadScene("Stage5");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage6ButtonClicked()
    {
        SceneManager.LoadScene("Stage6");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage7ButtonClicked()
    {
        SceneManager.LoadScene("Stage7");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage8ButtonClicked()
    {
        SceneManager.LoadScene("Stage8");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage9ButtonClicked()
    {
        SceneManager.LoadScene("Stage9");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage10ButtonClicked()
    {
        SceneManager.LoadScene("Stage10");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
    public void OnStage11ButtonClicked()
    {
        SceneManager.LoadScene("Stage11");
        SceneManager.UnloadSceneAsync("StageSelection");
    }
}
