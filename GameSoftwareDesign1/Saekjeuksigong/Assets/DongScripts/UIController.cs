using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour {
    public Image[] Life;
    public RawImage gameOverImg;
    public RawImage ResetImg;
    

    public Text gameOverText;
    public Text ScoreText;
    public Text resetNotifyText;


    

    // Use this for initialization
    void Start () {
        ScoreText.text = "스코어: 0";
        gameOverText.text = "";
        resetNotifyText.text = "";
        gameOverImg.gameObject.SetActive(false);
        ResetImg.gameObject.SetActive(false);

        
    }
	public void SetScore(int value)  //동전 먹을시? 스코어 여부 아직 확실치 않음
    {
        ScoreText.text = "스코어: " + value.ToString();
    }
    public void LoseLife(int deathcount)  //죽으면 라이프 하나 감소 UI
    {
        Life[deathcount].gameObject.SetActive(false);
           
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over";
        resetNotifyText.text = "To restart press Enter";
        gameOverImg.gameObject.SetActive(true);
        ResetImg.gameObject.SetActive(true);
        

    }
    
    public void Reset()
    {
        ScoreText.text = "스코어: 0";
        gameOverText.text = "";
        resetNotifyText.text = "";
        gameOverImg.gameObject.SetActive(false);
        ResetImg.gameObject.SetActive(false);
        for(int i = 0; i < 3; i++)
        {
            Life[i].gameObject.SetActive(true);
        }

    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
