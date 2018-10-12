using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerGameOver : MonoBehaviour {

	private GameObject gameOverPanel;
	private bool GameIsOverEffect = false;

	void Start ()
	{
		gameOverPanel = GameObject.Find("GameOver Panel");
		gameOverPanel.gameObject.SetActive (false);
	}

	public void GameOver () 
	{
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
