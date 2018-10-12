using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkSpawnerCheckerCollision : MonoBehaviour {

	[SerializeField]
	private string playerName;

	private GameObject gameManager;

	void Awake () {
		gameManager = GameObject.Find("GameManager");
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.name == playerName)
		{
			gameManager.GetComponent<GameManagerChunkSpawner>().SpawnChunk ();
			gameManager.GetComponent<GameManagerChunkSpawner>().distance += 0.1f;
		}
	}
}
