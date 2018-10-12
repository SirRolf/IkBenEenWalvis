using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Floris van den Berg
public class Playerlocomotion : MonoBehaviour {
	//just so you can change the name of the player if the game object "player" changes name
	[SerializeField]
	private string playerName;

	private GameObject player;
	private Rigidbody2D playerRigid;
	private bool playerUnderWater;

	[SerializeField]
	private Vector3 forceDownwards = new Vector3(0,-10,0);
	[SerializeField]
	private Vector3 direction;

	private float space;

	[SerializeField]
	private float moveSpeed;

	void Start() {
		player = GameObject.Find(playerName);
		playerRigid = player.GetComponent<Rigidbody2D>();
	}

	void Update () {

		playerUnderWater = player.GetComponent<PlayerWaterCollision> ().IsUnderWater;
		// currentposition + velocity(direction * movespeed)
		transform.Translate(direction * moveSpeed * Time.deltaTime);

		space = Input.GetAxisRaw ("Space");
		if (space == 1 && playerUnderWater == true) {
			playerRigid.AddForce(forceDownwards);
		}
	}
}
