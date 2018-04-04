using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitbullcalling : MonoBehaviour {

	public GameObject show;

	// Use this for initialization
	void Start () {
		show.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

	}
	/*
	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			show.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			show.SetActive (false);
		}
	}
	*/
}
