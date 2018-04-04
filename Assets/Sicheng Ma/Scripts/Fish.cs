using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour 
{
	[SerializeField]
	float dps = 1;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay (Collider other)
	{

		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools damage = p1.GetComponent<CJC_PlayerAndBools> ();
		GameObject healthref = GameObject.Find ("Health");
		CJC_HealthPFI Health = healthref.GetComponent<CJC_HealthPFI> ();

		if (other.tag == "Player")
		{
			GetComponent<AudioSource> ().enabled = true;
			damage.PlayerHurt = true;
			damage.PlayerHealth -= dps;
			CJC_Scoring.PlayerScore -= 1;
			Health.Playerdamaged = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			GetComponent<AudioSource> ().enabled = false;
		}
	}
}
