using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerQuoteManager : MonoBehaviour {

	[SerializeField]
	private GameObject[] quotes;

	private float timer;
	private float timerTillStopQuote;
	private float timeTillPlay = 0;

	private bool quoteActive = false;

	private int quotePicker;

	void Start() {
		
	}

	void Update () {
		//don't fuck with the time
		timer += Time.deltaTime;


		if (timeTillPlay == 0) {
			timeTillPlay = UnityEngine.Random.Range (5, 8);
		} else if (timer >= timeTillPlay) {
			PlayQuote ();
			timer = 0;
			timeTillPlay = 0;
			quoteActive = true;
		}
		if(quoteActive == true)
		{
			timerTillStopQuote += Time.deltaTime;
			if (timerTillStopQuote >= 3) {
				StopQuote ();
			}	
		}
	}

	void PlayQuote()
	{
		quotePicker = UnityEngine.Random.Range (0, 5);
		print ("quote: " + quotePicker);
		quotes[quotePicker].gameObject.SetActive (true);
	}

	void StopQuote()
	{
		quotes[quotePicker].gameObject.SetActive (false);
		timer = 0;
		timeTillPlay = 0;
		timerTillStopQuote = 0;
		quoteActive = false;
	}
}
