using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_RandomColor : MonoBehaviour {

	int[] numbers = { 0, 1, 2, 3 };

	[SerializeField]
	int chosennumber;

	[SerializeField]
	bool DoneOnce = false;

	[SerializeField]
	bool insidePortal = false;

	[SerializeField]
	AudioClip decolorsound;
	[SerializeField]
	AudioSource decolorsource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log (DoneOnce);
		//Debug.Log (insidePortal);

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (chosennumber == 0  && !DoneOnce && insidePortal) 
		{
			if (!player.IsGreen)
			{GetComponent<AudioSource> ().PlayOneShot (decolorsound);
				Debug.Log ("turning player green");
				player.IsGreen = true;
				player.IsRed = false;
				player.IsYellow = false;
				player.IsPurple = false;
				DoneOnce = true;
			}
			else if (player.IsGreen) 
			{
				DoneOnce = false;
			}
		}
		else if (chosennumber == 1 && !DoneOnce && insidePortal) 
		{
			if (!player.IsRed)
			{GetComponent<AudioSource> ().PlayOneShot (decolorsound);
			Debug.Log ("turning player red");
			player.IsGreen = false;
			player.IsRed = true;
			player.IsYellow = false;
			player.IsPurple = false;
			DoneOnce = true;
			}
			else if (player.IsRed) 
			{
				DoneOnce = false;
			}
		}
		else if (chosennumber == 2 && !DoneOnce && insidePortal) 
		{
			if (!player.IsYellow)
			{GetComponent<AudioSource> ().PlayOneShot (decolorsound);
			Debug.Log ("turning player yellow");
			player.IsGreen = false;
			player.IsRed = false;
			player.IsYellow = true;
			player.IsPurple = false;
			DoneOnce = true;
			}
			else if (player.IsYellow) 
			{
				DoneOnce = false;
			}
		}
		else if (chosennumber == 3 && !DoneOnce && insidePortal) 
		{
			if (!player.IsPurple)
			{
				GetComponent<AudioSource> ().PlayOneShot (decolorsound);
			Debug.Log ("turning player purple");
			player.IsGreen = false;
			player.IsRed = false;
			player.IsYellow = false;
			player.IsPurple = true;
			DoneOnce = true;
			}
			else if (player.IsPurple) 
			{
				DoneOnce = false;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player")
		{
			
			insidePortal = true;

			if (!DoneOnce) {
				chosennumber = Random.Range (0, numbers.Length);

				Debug.Log ("chosen number is " + chosennumber);
			}
		}


	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") 
		{
			insidePortal = false;
			DoneOnce = false;
		}
	}
}
