using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exitlevel6 : MonoBehaviour {

	static public bool finishLevel;

	// Use this for initialization
	void Start () {
		finishLevel = false;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		GameObject dir = GameObject.FindWithTag ("Player");
		CJC_PlayerAnimController anim = dir.GetComponent<CJC_PlayerAnimController> ();
		if (other.tag == "Player") 
		{
			anim.animCompletedLevel = true;
			finishLevel = true;
			Checkpoint.reachedcheckpoint21 = false;
			Checkpoint.reachedcheckpoint22 = false;
			Checkpoint.reachedcheckpoint23 = false;
			Checkpoint.reachedcheckpoint24 = false;
			CJC_Scoring.PlayerScore += 1400;
			CJC_Scoring.hasbeenscored6 = true;
			countingtime.startcounting = false;
		}
	}
}
