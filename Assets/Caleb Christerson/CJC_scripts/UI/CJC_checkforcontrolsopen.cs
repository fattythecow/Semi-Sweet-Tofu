using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_checkforcontrolsopen : MonoBehaviour {

	[SerializeField]
	GameObject controls = null;
	public bool ControlsOpen = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();

		if (controls.activeInHierarchy == true) {
			ControlsOpen = true;
		} else if (controls.activeInHierarchy == false)
			ControlsOpen = false;
	}
}
