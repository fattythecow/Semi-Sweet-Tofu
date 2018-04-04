using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notdropplz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "GrapeFruit" || other.tag == "Banana" || other.tag == "Grape" || other.tag == "Apple" || other.tag == "Strawberry" || other.tag == "Durian") {
			Destroy (other.gameObject);
		}
	}
}
