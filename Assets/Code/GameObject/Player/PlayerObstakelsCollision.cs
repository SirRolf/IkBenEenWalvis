using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObstakelsCollision : MonoBehaviour {
    [SerializeField]
    private float damage = -15;
    private GameObject healthbar;
    private string greenHealthbar;
    void Start() {
        healthbar = GameObject.Find("greenHealthBar");
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "obstackel")
        {
            healthbar.transform.localScale = healthbar.transform.localScale - new Vector3(damage, 0,0);
            Destroy(col.gameObject);
        }
    }
}

