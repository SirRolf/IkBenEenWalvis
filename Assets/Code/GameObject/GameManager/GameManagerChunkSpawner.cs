using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerChunkSpawner : MonoBehaviour {

	private Vector3 spawnChunkLocation = new Vector3(0,-9,0);

	private float chunkNumberCreate = 0f;
	private float chunkNumberRemove = -2f;

	public float distance = 0;

	//[SerializeField]
	//private GameObject chunk1;
	//[SerializeField]
	//private GameObject chunk2;
	//[SerializeField]
	//private GameObject chunk3;
	//[SerializeField]
	//private GameObject chunk4;
	//[SerializeField]
	//private GameObject chunk5;

	[SerializeField]
	private GameObject[] chunks;

	void Start () {
	}

	public void SpawnChunk () {
		chunkNumberCreate++;
		chunkNumberRemove++;
		spawnChunkLocation = spawnChunkLocation + new Vector3 (40,0,0);
		GameObject chunk = Instantiate(chunks[UnityEngine.Random.Range(0,4)], spawnChunkLocation, Quaternion.identity);
		chunk.name = "chunk" + chunkNumberCreate;
		Destroy (GameObject.Find("chunk" + chunkNumberRemove));
	}
}
