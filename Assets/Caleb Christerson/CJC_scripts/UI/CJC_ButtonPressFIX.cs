using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CJC_ButtonPressFIX : MonoBehaviour
{
	
	public Sprite pressdown;
	public Sprite selected;

	public GameObject button;
	bool pressed = false;

	public static bool nocontrols;

	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip backbuttonpressed;
	// Use this for initialization
	void Start () {
		button.GetComponent<Image> ().sprite = selected;
	}
	
	// Update is called once per frame
	void Update ()
	{
		PressFuckingButtonsAndShit ();
		if (!pressed) {
			button.GetComponent<Image> ().sprite = selected;
		}
	}

	void ReadyUp(){
		GameObject coregame = GameObject.FindWithTag ("GameCore");
		CJC_pauseActions core = coregame.GetComponent<CJC_pauseActions> ();
		GameObject coreg = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core1 = coreg.GetComponent<CJC_PauseShit> ();

		core.ControllerToldMeToTurnYouOn = false;
		core.controls.SetActive (false);
		core.pausemenu.SetActive (true);
		core1.paused = true;
		pressed = false;
		nocontrols = false;
	}

	void PressFuckingButtonsAndShit()
	{
		GameObject coregame1 = GameObject.FindWithTag ("GameCore");
		CJC_PauseShit core1 = coregame1.GetComponent<CJC_PauseShit> ();

		if (Input.GetButtonDown ("360_BButton") | Input.GetKeyDown (KeyCode.Return)) 
		{

			GetComponent<AudioSource> ().PlayOneShot (backbuttonpressed);
			pressed = true;
			button.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", 0.2f);
			core1.paused = false;
			nocontrols = true;
		}
	}
}
