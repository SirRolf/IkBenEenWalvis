using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerGameOver : MonoBehaviour {

	private GameObject gameOverPanel;
	private GameObject distance;
	private bool GameIsOverEffect = false;

	void Start ()
	{
		distance = GameObject.Find("Distance");
		gameOverPanel = GameObject.Find("GameOver Panel");
		gameOverPanel.gameObject.SetActive (false);
	}

	public void GameOver () 
	{
		if (distance.GetComponent<DistanceScore>().distance > PlayerPrefs.GetFloat ("HighScore", 0)) {
			PlayerPrefs.SetFloat ("HighScore", distance.GetComponent<DistanceScore>().distance);
		}
		GameIsOverEffect = true;
		gameOverPanel.gameObject.SetActive (true);
	}

	void Update ()
	{
		if(GameIsOverEffect == true)
		{
			Time.timeScale -= 0.01f;
			Time.fixedDeltaTime = Time.timeScale * .02f;
		}
	}
}
