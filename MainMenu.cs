using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		Application.Quit();
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ("race");
		}
		if(Input.GetKeyDown(KeyCode.M)){
			Application.LoadLevel("main");
		}
	}
}
