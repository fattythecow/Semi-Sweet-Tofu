using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_FunkyBunch : MonoBehaviour {

	public bool particlePlay = false;
	public GameObject PFI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player") {
			particlePlay = true;
			PFI.SetActive(true);

		}

	}

	void OnTriggerExit (Collider other) {

		particlePlay = true;
		PFI.SetActive (false);
	}
}
