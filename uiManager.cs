using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class uiManager : MonoBehaviour {

    public Text scoreText;
    bool gameOver;
	public Text gameOverText;
    int score;
	// Use this for initialization
	void Start () {
        gameOver = false;
		gameOverText.text = "";
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
      
	}
    void scoreUpdate() {
        if (gameOver == false){
            score += 1;
        }
    }
    public void gameOverActivated(){ 
		gameOverText.text = "Game Over!";
        gameOver = true;
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
}
