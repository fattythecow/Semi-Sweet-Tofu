﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitcolliders : MonoBehaviour {

	public GameObject icont;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			icont.SetActive (true);
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			icont.SetActive (false);
		}
	}
}