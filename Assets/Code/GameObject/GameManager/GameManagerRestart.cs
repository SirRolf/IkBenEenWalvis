using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerRestart : MonoBehaviour {

	private float distance;

	void Start()
	{
	}

	void Update () {
		distance = this.GetComponent<GameManagerChunkSpawner>().distance;
		if(Input.GetKeyDown("r")){
			//save the high score
			if (distance > PlayerPrefs.GetFloat ("HighScore", 0)) {
				PlayerPrefs.SetFloat ("HighScore", distance);
			}
			Time.timeScale = 1;
			SceneManager.LoadScene (1);
			Time.fixedDeltaTime = .02f;
		}
	}
}
