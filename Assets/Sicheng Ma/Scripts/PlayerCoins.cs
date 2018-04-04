using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoins : MonoBehaviour {

	static public int playerCoins = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		GameObject p1 = GameObject.Find ("starttime");
		countingtime player = p1.GetComponent<countingtime> ();

		GameObject healthref = GameObject.Find ("Timer");
		TimerPFI health = healthref.GetComponent<TimerPFI> ();

		if (other.gameObject.name == "Coin") {
			Destroy (other.gameObject);
			playerCoins += 1;
			player.leveltimer -= 3;
			health.isreduced = true;
			/*
			if (player.RestartLevel == "PieSlice1") {
				CJC_Scoring.timeT -= 10;
			} 
			else if (player.RestartLevel == "PieSlice2") {
				CJC_Scoring.time1 -= 10;
			} 
			else if (player.RestartLevel == "PieSlice3") {
				CJC_Scoring.time2 -= 10;
			}
			else if (player.RestartLevel == "Level3") {
				CJC_Scoring.time3 -= 10;
			}
			else if (player.RestartLevel == "Level4") {
				CJC_Scoring.time4 -= 10;
			}
			else if (player.RestartLevel == "Level5") {
				CJC_Scoring.time5 -= 10;
			}
			else if (player.RestartLevel == "Level6") {
				CJC_Scoring.time6 -= 10;
			}
			*/
		}
	}
}
