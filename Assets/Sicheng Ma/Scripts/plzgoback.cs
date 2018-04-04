using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class plzgoback : MonoBehaviour {

	public bool acehod = false;

	void Start(){

	}

	void Update(){

	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "Wall")
		{
			Debug.Log ("turnback");
			acehod = true;
		} 
	}

	void OnTriggerExit(Collider other)
	{

		if (other.tag == "Wall")
		{
			Debug.Log ("turnback");
			acehod = false;
		} 
	}
}
