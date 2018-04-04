using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CJC_controlsGoBack : MonoBehaviour {

	[SerializeField]
	string Scene;

	public Sprite pressdown;
	public Sprite selected;

	public GameObject button;
	bool pressed = false;

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
	}

	void ReadyUp(){
		SceneManager.LoadScene (Scene);
	}

	void PressFuckingButtonsAndShit()
	{ 
		if (Input.GetButtonDown ("360_BButton") | Input.GetKeyDown (KeyCode.Return)) 
		{
			GetComponent<AudioSource> ().PlayOneShot (backbuttonpressed);
			pressed = true;
			button.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", 1f);
		}
	}
}
