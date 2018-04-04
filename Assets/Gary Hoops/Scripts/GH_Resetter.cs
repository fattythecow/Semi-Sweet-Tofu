using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_Resetter : MonoBehaviour {

	public Material closed;
	public GameObject box;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter (Collider other){

		if (other.tag == "Player"){

			box.GetComponent<Renderer> ().material = closed;


		

	}
}
}
