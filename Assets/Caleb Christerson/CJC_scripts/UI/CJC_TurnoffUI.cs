using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_TurnoffUI : MonoBehaviour 
{
	[SerializeField]
	float turnofftimer = 0;
	[SerializeField]
	float turnoffmax = 1.5f;

	bool turnoff = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		turnofftimer += Time.deltaTime;

		if (turnofftimer >= turnoffmax) 
		{
			turnoff = true;
			turnofftimer = 0;
		}

		if (turnoff == true) 
		{
			Invoke ("Turnoff",0);
		}
	}

	void Turnoff()
	{
		turnoff = false;
		gameObject.SetActive (false);
	}
}
