using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacklesLocationReset : MonoBehaviour {

	private GameObject player;

	[SerializeField]
	private string playerName;

	[SerializeField]
	private float maxHeight;
	[SerializeField]
	private float minHeight;

	void Start () {
		player = GameObject.Find(playerName);

		Vector3 relocateLocation = new Vector3 (15 + player.transform.position.x, UnityEngine.Random.Range (maxHeight, minHeight), 0);

		gameObject.transform.position = relocateLocation;
	}
}
