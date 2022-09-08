using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToStageSelectionController : MonoBehaviour {

	public void OnGoToStageSelectionButtonClicked()
    {
        SceneManager.LoadScene("StageSelection");
    }
}
