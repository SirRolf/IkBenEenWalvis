using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreScore : MonoBehaviour {
	
	private Text textComponent;

	// Use this for initialization
	void Update () {
		print ("le chat");
		textComponent = GetComponent<Text>();
		textComponent.text = "highscore is " + PlayerPrefs.GetFloat ("HighScore", 0) + " Km";
	}
}
