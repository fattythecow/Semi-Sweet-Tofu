using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_DecolorMachine : MonoBehaviour {

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

	}

	void OnTriggerStay(Collider other)
	{

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Player") 
		{
			if (player.IsGreen | player.IsRed | player.IsYellow | player.IsPurple)
			{
				GetComponent<AudioSource> ().PlayOneShot (decolorsound);
				player.IsGreen = false;
				player.IsRed = false;
				player.IsYellow = false;
				player.IsPurple = false;
			}
		}

	}
}
