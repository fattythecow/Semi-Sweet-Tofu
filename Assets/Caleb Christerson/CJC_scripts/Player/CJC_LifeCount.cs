using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CJC_LifeCount : MonoBehaviour
{
	static public int PlayerLives = 3;

	[SerializeField]
	string GameOver = "";

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		handleLives ();
	}

	void handleLives()
	{
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_Starvation Starve = p1.GetComponent<CJC_Starvation> ();

		GameObject player = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools Player = player.GetComponent<CJC_PlayerAndBools> ();

		if (PlayerLives <= 0) {
			SceneManager.LoadScene (GameOver);
			PlayerLives = 3;
			if (Player.RestartLevel == "PieSlice1") {
				Checkpoint.reachedcheckpoint25 = false;
				CJC_Scoring.timeT = 0;
				PlayerCoins.playerCoins = 0;
			}
			else if (Player.RestartLevel == "PieSlice2") {
				Checkpoint.reachedCheckpoint = false;
				Checkpoint.reachedCheckpoint2 = false;
				CJC_Scoring.time1 = 0;
				PlayerCoins.playerCoins = 0;
			} else if (Player.RestartLevel == "PieSlice3") {
				Checkpoint.reachedCheckpoint3 = false;
				Checkpoint.reachedcheckpoint4 = false;
				Checkpoint.reachedcheckpoint5 = false;
				Checkpoint.reachedcheckpoint6 = false;
				CJC_Scoring.time2 = 0;
				PlayerCoins.playerCoins = 0;
			}else if (Player.RestartLevel == "Level3") {
				Checkpoint.reachedcheckpoint7 = false;
				Checkpoint.reachedcheckpoint8 = false;
				Checkpoint.reachedcheckpoint9 = false;
				Checkpoint.reachedcheckpoint10 = false;
				Checkpoint.reachedcheckpoint11 = false;
				CJC_Scoring.time3 = 0;
				PlayerCoins.playerCoins = 0;
			}else if (Player.RestartLevel == "Level4") {
				Checkpoint.reachedcheckpoint16 = false;
				Checkpoint.reachedcheckpoint17 = false;
				Checkpoint.reachedcheckpoint18 = false;
				Checkpoint.reachedcheckpoint19 = false;
				Checkpoint.reachedcheckpoint20 = false;
				CJC_Scoring.time4 = 0;
				PlayerCoins.playerCoins = 0;
			}else if (Player.RestartLevel == "Level5") {
				Checkpoint.reachedcheckpoint12 = false;
				Checkpoint.reachedcheckpoint13 = false;
				Checkpoint.reachedcheckpoint14 = false;
				Checkpoint.reachedcheckpoint15 = false;
				CJC_Scoring.time5 = 0;
				PlayerCoins.playerCoins = 0;
			}else if (Player.RestartLevel == "Level6") {
				Checkpoint.reachedcheckpoint21 = false;
				Checkpoint.reachedcheckpoint22 = false;
				Checkpoint.reachedcheckpoint23 = false;
				Checkpoint.reachedcheckpoint24 = false;
				CJC_Scoring.time6 = 0;
				PlayerCoins.playerCoins = 0;
			}
		}
	}



}
