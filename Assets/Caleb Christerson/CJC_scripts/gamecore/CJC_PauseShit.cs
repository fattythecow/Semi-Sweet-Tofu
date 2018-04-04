using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_PauseShit : MonoBehaviour 
{
	public bool paused = false;
	string pausestate = "";

	[SerializeField]
	GameObject pausemenu;

	// Use this for initialization
	void Start () 
	{
		HandlePause (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		CheckInput ();
		CheckPuase ();

		if (paused) 
		{
			return;
		}
	}

	void CheckPuase()
	{
		if (paused == false) 
		{
			pausestate = "enabled";
		}
		else if (paused == false) 
		{
			pausestate = "disabled";
		}
	}

	void CheckInput()
	{
		GameObject soppe = GameObject.Find ("ShopCalling");
		ShopController shop = soppe.GetComponent<ShopController> ();

		GameObject pausee = GameObject.Find ("ShopCanvas");
		CJC_checkforcontrolsopen pause = pausee.GetComponent<CJC_checkforcontrolsopen> ();

		if (shop.isopen == false && pause.ControlsOpen == false)
		{

			if (Input.GetKeyUp (KeyCode.Escape) | Input.GetButtonDown ("360_StartButton") | Input.GetButtonDown ("ps4_StartButton")) {
				HandlePause (!paused);
			}
		}

		if (paused) {
			if (Input.GetButtonDown ("360_BButton") && ShopController.PressedB == false) {
				HandlePause (!paused);
				ShopController.PressedB = true;
			}
		}

	}

	void SetPaused (bool _paused)
	{
		paused = _paused;

		if (paused)
		{
			Time.timeScale = 0;
		}
		else 
		{
			Time.timeScale = 1;
		}
	}

	public static void MakeChild(GameObject _child)
	{
		GameObject coreGameObj = GameObject.FindWithTag ("GameCore");

		_child.transform.parent = coreGameObj.transform;
	}

	public void HandlePause (bool _pause)
	{
		paused = _pause;

		BroadcastMessage ("SetPaused", paused);

		if (paused)
		{
			Time.timeScale = 0;
		}
		else 
		{
			Time.timeScale = 1;
		}

		pausemenu.SetActive (paused);
	}
}

