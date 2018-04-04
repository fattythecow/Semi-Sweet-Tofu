using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CJC_LeaveSplash : MonoBehaviour {

	[SerializeField]
	string GoToTitle;

	[SerializeField]
	bool atTitle = false;

	public Sprite pressdown;
	public Sprite selected;

	public GameObject button;
	bool pressed = false;

	[SerializeField]
	AudioSource Source;
	[SerializeField]
	AudioClip buttonpressed;

	// Use this for initialization
	void Start () {
		button.GetComponent<Image> ().sprite = selected;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.Return) && atTitle) 
		{
			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			pressed = true;
			button.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", .5f);
		}
		else if (Input.GetButtonDown ("360_StartButton") && atTitle) 
		{
			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			pressed = true;
			button.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", .5f);
		}
		else if (Input.GetButtonDown ("360_AButton") && atTitle) 
		{
			GetComponent<AudioSource> ().PlayOneShot (buttonpressed);
			pressed = true;
			button.GetComponent<Image> ().sprite = pressdown;
			Invoke ("ReadyUp", .5f);
		}
	}

	void ReadyUp(){
		SceneManager.LoadScene (GoToTitle);
	}




}
