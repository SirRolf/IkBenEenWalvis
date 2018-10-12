using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoodCollision : MonoBehaviour {
    [SerializeField]
    private float addhealth = 10;
    private GameObject healthbar;
    private string greenHealthBar;
	void Start () {
        healthbar = GameObject.Find("greenHealthBar");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "food")
        {
            healthbar.transform.localScale = healthbar.transform.localScale + new Vector3(addhealth, 0, 0);
            Destroy(col.gameObject);
        }
    }
   
}
