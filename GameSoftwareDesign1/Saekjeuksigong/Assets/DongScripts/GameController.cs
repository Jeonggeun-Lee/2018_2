using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    private UIController ui;
    private bool isGameOver;
    private PlayerController player;

    private Coroutine hazardRoutine;
    public float StartWaitingTime;
    public float StageTimeGap;
	// Use this for initialization
	void Start () {
        isGameOver = false;
        ui = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        hazardRoutine = StartCoroutine(Hazards(StartWaitingTime, StageTimeGap));
	}

    private IEnumerator Hazards(float startTime, float stageGap)  //수정중
    {
        WaitForSeconds gap = new WaitForSeconds(stageGap);
        yield return gap;

        yield return new WaitForSeconds(startTime);
        
    }
    public void Restart()
    {
        hazardRoutine = StartCoroutine(Hazards(StartWaitingTime, StageTimeGap));
        
        ui.Reset();
        isGameOver = false;
        player.gameObject.SetActive(true);
        player.transform.position = new Vector3(0,1,0);     
    }
    public void GameOver()
    {
        ui.GameOver();
        player.gameObject.SetActive(false);
        StopCoroutine(hazardRoutine);
        isGameOver = true;
    }

    // Update is called once per frame
    void Update () {   //수정중 엔터키가 아닌 버튼을 추후 만들 예정
        if (Input.GetKeyDown(KeyCode.Return) && isGameOver)
        {
            //SceneManager.LoadScene(0); //나중에 추가..
            Restart();
        }
    }
}
