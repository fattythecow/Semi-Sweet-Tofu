using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWall : MonoBehaviour {

	public GameObject box;

	//public Material block;
	public Material open;


	// Use this for initialization
	void Start () {
		box.GetComponent<Renderer> ().material = open;

	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnTriggerEnter  (Collider other){

		if (other.tag == "Player") {

			box.GetComponent<BoxCollider> ().enabled = false;
			box.GetComponent<Renderer> ().material = open;


		
		} //else
			//box.GetComponent<BoxCollider> ().enabled = true;

	}




	void OnTriggerExit (Collider other){

		box.GetComponent<BoxCollider> ().enabled = true;

		//if (other.tag == "Player") {


			//box.GetComponent<Renderer> ().material = block;
		//}
}
}
