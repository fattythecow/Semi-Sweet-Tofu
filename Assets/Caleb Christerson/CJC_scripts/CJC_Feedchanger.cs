using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_Feedchanger : feedme
{



	[SerializeField]
	Material yellow = null;
	[SerializeField]
	Material red = null;
	[SerializeField]
	Material purple = null;
	[SerializeField]
	Material green = null;

	bool doonce = true;

	bool fedonce = true;
	bool fedtwice = true;

	public GameObject times;

	public float feedtimer = 0;

	public TextMesh TimeTextMesh;
	private string timeText;

	public byte alplha2 = 255;
	bool isfed2 = false;

	// Use this for initialization
	void Start ()
	{
		text1.SetActive (true);
		text2.SetActive (false);
		text3.SetActive (false);
		times.SetActive (false);
		timeText = TimeTextMesh.text;
	}


	void gottenfed()
	{


		if (isfed2)
		{
			
			alplha2--;
			alplha2--;

		}

		if (alplha2 <= 15)
		{
			alplha2 = 0;
			Destroy (gameObject, 0);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, alplha2);
		gottenfed ();
		UpdateTime ("   " + feedtimer.ToString("0"));

		if (isYellow) {
			times.SetActive (false);
		} else {
			times.SetActive (true);
		}

		if (feedtimer <= 0 && feedtime != 0) {

			goback ();
		}

		if (isRed)
		{
			GetComponent<MeshRenderer> ().material = red;
		}
		else if (isYellow)
		{
			GetComponent<MeshRenderer> ().material = yellow;
		}
		else if (isGreen)
		{
			GetComponent<MeshRenderer> ().material = green;
		}
		else if (isPurple)
		{
			GetComponent<MeshRenderer> ().material = purple;
		}
		if (!isfed2) {
			feedtimer -= Time.deltaTime;
		}

		if (feedtime == 0) {
			text1.SetActive (true);
			text2.SetActive (false);
			text3.SetActive (false);
		}
		else if (feedtime == 1) 
		{
			text1.SetActive (false);
			text2.SetActive (true);
			text3.SetActive (false);
			if (fedonce) {
				changecolortype ();
				fedonce = false;
			} 
		}
		else if (feedtime == 2) 
		{
			text1.SetActive (false);
			text2.SetActive (false);
			text3.SetActive (true);
			if (fedtwice) {
				changecolortype ();
				fedtwice = false;
			}
		}
		else if (feedtime == maxfeedtime) {
			isfed2 = true;
		}
		changefruitmaterial ();

	}

	public void UpdateTime(string value){
		TimeTextMesh.text = timeText;
		TimeTextMesh.text += value;
	}

	void goback(){
		
		feedtimer = 12;

		if (isPurple) {
			isYellow = true;
			isPurple = false;
			feedtime = 0;
			fedonce = true;
		} else if (isGreen) {
			isPurple = true;
			isGreen = false;
			feedtime = 1;
			fedtwice = true;
		}
	}


	void changecolortype()
	{
		feedtimer = 12;
			if (isYellow)
			{
				isPurple = true;
				isYellow = false;
			} 
			else if (isPurple)
			{
				isGreen = true;
				isPurple = false;
			}
			else if (isGreen)
			{
				isRed = true;
				isGreen = false;
			}
			else if (isRed)
			{
				isYellow = true;
				isRed = false;
			}
	}
}
