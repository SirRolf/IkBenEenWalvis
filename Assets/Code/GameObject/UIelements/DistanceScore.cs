using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DistanceScore : MonoBehaviour {
    private GameObject gameManager;
    private Text textComponent;
    public float distance;
    
    void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        textComponent = GetComponent<Text>();
    }

    
    void Update () {
        distance = gameManager.GetComponent<GameManagerChunkSpawner>().distance;
        textComponent.text = "distance traveled " + distance + " Km";
    }
}
