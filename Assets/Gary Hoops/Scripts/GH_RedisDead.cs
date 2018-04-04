using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_RedisDead : MonoBehaviour {
	[SerializeField]
	GameObject player;
	float Isdamagedtimer = .1f;
	bool Isdamagedwhite = true;
	bool IsdamagedRed = false;
	bool IsDamaged = false;
	float Maxtimer = .1f;

	// Use this for initialization
	void Start ()
	{
		Isdamagedwhite = true;
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfDamaged ();
		CheckWhite ();
	}

	void CheckIfDamaged ()
	{
		player = GameObject.Find ("Health");
		CJC_HealthPFI playee = player.GetComponent<CJC_HealthPFI> ();

		if (playee.Playerdamaged == true)
		{
			Debug.Log ("heyyy");
			Isdamagedtimer += Time.deltaTime;

			if (Isdamagedtimer >= Maxtimer && IsdamagedRed == true)
			{
				Isdamagedwhite = true;
				Isdamagedtimer = 0;
				IsdamagedRed = false;
			}
			else if (Isdamagedtimer >= Maxtimer && Isdamagedwhite == true)
			{
				IsdamagedRed = true;
				Isdamagedtimer = 0;
				Isdamagedwhite = false;
			}
		}
		else if (playee.Playerdamaged == false)
		{
			
		}
	}

	void CheckWhite()
	{

		player = GameObject.Find ("Health");
		CJC_HealthPFI playee = player.GetComponent<CJC_HealthPFI> ();

		if (playee.Playerdamaged == false)
		{
			Isdamagedwhite = true;
			IsdamagedRed = false;
		}

		if (Isdamagedwhite == true)
		{
			//Debug.Log("Me not working hard?\nYeah, right, picture that with a Kodak");
			Debug.Log("panda panda panda panda panda." +
				" i got broads in atlanta, twistin dope, lean and the fanta\n" +
				"credits cards and the scammers" +
				" hittin off licks in the bando");

			gameObject.GetComponent<MeshRenderer> ().material.color = Color.white;
		}
		else if (IsdamagedRed == true) 
		{
			gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
		}

	}
}