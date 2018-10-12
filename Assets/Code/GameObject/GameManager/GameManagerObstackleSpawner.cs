using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerObstackleSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject[] obstackles;

	private float timer;
	private float timeTillSpawn = 0;

	void Update () {
		//don't fuck with the time
		timer += Time.deltaTime;


		if (timeTillSpawn == 0) {
			timeTillSpawn = UnityEngine.Random.Range (3, 4);
		} else if (timer >= timeTillSpawn) {
			SpawnObstackle ();
			timer = 0;
			timeTillSpawn = 0;
		}
	}

	void SpawnObstackle()
	{
		Vector3 spawnObstacklesLocation = new Vector3 (-100,-100,-100); 

		Instantiate(obstackles[0], spawnObstacklesLocation, Quaternion.identity);
		Instantiate(obstackles[1], spawnObstacklesLocation, Quaternion.identity);
	}
}
