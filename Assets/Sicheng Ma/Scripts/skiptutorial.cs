using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skiptutorial : MonoBehaviour {

	public GameObject askforskip;

	public static bool hasasked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		GameObject dir = GameObject.Find ("CoreGameController");
		CJC_PauseShit p2 = dir.GetComponent<CJC_PauseShit> ();


		if (player.RestartLevel == "PieSlice1" && !Checkpoint.reachedcheckpoint25 ) {
			if (!hasasked) {
				askforskip.SetActive (true);
				hasasked = true;
			}
		} else {
			askforskip.SetActive (false);

		}
	
		if (askforskip.activeInHierarchy) {
			Time.timeScale = 0;
		}
	
	}
}
