using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconActivated : MonoBehaviour {
	public GameObject jumpicon;

	public GameObject speedicon;

	public GameObject staminaicon;

	public GameObject pointicon;

	public GameObject plate;


	// Use this for initialization
	void Start () {
		jumpicon.SetActive (false);
		speedicon.SetActive (false);
		staminaicon.SetActive (false);
		pointicon.SetActive (false);
		plate.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		ActivateIcon ();
	}

	void ActivateIcon(){
		GameObject core = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools gamecore = core.GetComponent<CJC_PlayerAndBools> ();

		if (gamecore.IsGreen) {
			jumpicon.SetActive (true);
			speedicon.SetActive (false);
			staminaicon.SetActive (false);
			pointicon.SetActive (false);
			plate.SetActive (true);
		} else if (gamecore.IsRed) {
			jumpicon.SetActive (false);
			speedicon.SetActive (false);
			staminaicon.SetActive (false);
			pointicon.SetActive (true);
			plate.SetActive (true);
		} else if (gamecore.IsYellow) {
			jumpicon.SetActive (false);
			speedicon.SetActive (true);
			staminaicon.SetActive (false);
			pointicon.SetActive (false);
			plate.SetActive (true);
		} else if (gamecore.IsPurple) {
			jumpicon.SetActive (false);
			speedicon.SetActive (false);
			staminaicon.SetActive (true);
			pointicon.SetActive (false);
			plate.SetActive (true);
		} else {
			jumpicon.SetActive (false);
			speedicon.SetActive (false);
			staminaicon.SetActive (false);
			pointicon.SetActive (false);
			plate.SetActive (true);
		}
	}
}
