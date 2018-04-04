using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TestVid : MonoBehaviour {

	public VideoPlayer testTexture;

	// Use this for initialization
	void Start () {

		GetComponent<Renderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerExit (Collider other) {

		GetComponent<Renderer> ().enabled = false;

	}




	void OnTriggerEnter (Collider other) {

		if (other.gameObject.tag == ("Player")) 
		{

			GetComponent<Renderer> ().enabled = true;
			testTexture.Play();

			

	}
}



}
