using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exitlevelagain : MonoBehaviour {
	
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
			CJC_Scoring.PlayerScore += 1100;
			CJC_Scoring.hasbeenscored3 = true;
			countingtime.startcounting = false;
		}


	}
}
