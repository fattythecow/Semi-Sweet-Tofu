using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour {

	public bool isopen;

	public GameObject shopPanel;

	public static bool PressedB = false;

	void Update()
	{
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();


		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (isopen | gamecore.paused) 
		{
			Time.timeScale = 0;
		}
		else if (!isopen && !gamecore.paused) 
		{
			Time.timeScale = 1;
		}

		/*
		if (player.RestartLevel != "PieSlice1") {

			if (gamecore.paused == false) {
				CheckforControllerInput ();
			}
		}
		*/
	}

	public void Openshop()
	{
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel != "PieSlice1") {
			if (gamecore.paused == false) {
				isopen = true;
				shopPanel.SetActive (true);
			}
		}
	}

	public void CloseShop()
	{ 
		GameObject core = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit gamecore = core.GetComponent<CJC_PauseShit> ();


		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (player.RestartLevel != "PieSlice1") {
			if (gamecore.paused == false) {
				isopen = false;
				shopPanel.SetActive (false);
			}
		}
	}

	public void CheckforControllerInput()
	{
		if (Input.GetButtonDown ("360_BackButton") && isopen == false) 
		{
			Openshop ();
		}
		else if (Input.GetButtonDown ("360_BButton") && isopen == true && PressedB == false) 
		{
			CloseShop ();
			PressedB = true;
		}
		else if (Input.GetButtonDown ("360_BackButton") && isopen == true) 
		{
			CloseShop ();
		}
		if (Input.GetKeyDown (KeyCode.RightShift) && isopen == false) 
		{
			Openshop ();
		}
		else if (Input.GetKeyDown (KeyCode.RightShift) && isopen == true) 
		{
			CloseShop ();
		}

	}


}
