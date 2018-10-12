using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarHealhtmanagement : MonoBehaviour {
    
	[SerializeField]
	private float healthdecay = 15f;

	private GameObject gameManager;
    

    void Start () {
		gameManager = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
       

        if (transform.localScale.x <= 0 )
        {
			gameManager.GetComponent<GameManagerGameOver>().GameOver();
        }
        else
        {
            transform.localScale -= new Vector3(healthdecay, 0, 0) * Time.deltaTime;
        }
        
	}
}
