using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {

	public Slider Volumes;
	public AudioSource Music;


	// Update is called once per frame
	void Update () 
	{
		Music.volume = Volumes.value;	
	}
}
