using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_showtutcontrols : MonoBehaviour {

	[SerializeField]
	GameObject Controller = null;
	[SerializeField]
	GameObject Keyboard = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckforTrue ();
	}

	void CheckforTrue()
	{
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_checkforcontrollerTUT core = coregame.GetComponent<CJC_checkforcontrollerTUT> ();

		if (core.controllerConnected == true)
		{
			Controller.SetActive (true);
			Keyboard.SetActive (false);
		} 
		else if (core.controllerConnected == false)
		{
			Controller.SetActive (false);
			Keyboard.SetActive (true);
		}
	}
}
