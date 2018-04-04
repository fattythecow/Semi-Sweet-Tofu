using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CJC_MessageTimer : MonoBehaviour {

	[SerializeField]
	float maxtimer = 2;

	[SerializeField]
	float currenttimer = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		currenttimer += Time.deltaTime;

		if (currenttimer >= maxtimer) 
		{
			currenttimer = 0;
			gameObject.SetActive (false);
		}
	}
}
