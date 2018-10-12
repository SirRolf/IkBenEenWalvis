using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Floris van den Berg
public class PlayerWaterCollision : MonoBehaviour {
	//just so you can change the name of the player if the game object "player" changes name
	[SerializeField]
	private string playerName;

	private bool isUnderWater = false;
	[SerializeField]
	private Vector3 force = new Vector3(0,20,0);
	[SerializeField]
	private string liquid = "Water";

	private GameObject player;
	private Rigidbody2D playerRigid;

	void Start() {
		player = GameObject.Find(playerName);
		playerRigid = player.GetComponent<Rigidbody2D>();
	}


	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag == liquid)
		{
			isUnderWater = false;
			playerRigid.gravityScale = 2f;
		}
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == liquid) {
			isUnderWater = true;
			playerRigid.gravityScale = 1f;
			playerRigid.AddForce (force);
			playerRigid.AddForce (playerRigid.velocity * -1);		
		}
	}

	//Geter setter for isUnderWater
	public bool IsUnderWater
	{
		get
		{
			return isUnderWater;
		}
		set
		{

		}
	}
}

