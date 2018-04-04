using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_ArrowBegone : MonoBehaviour {

	public GameObject arrow;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter (Collider other) {

		if (other.tag == "Player")
			Destroy (arrow);

	}
}
