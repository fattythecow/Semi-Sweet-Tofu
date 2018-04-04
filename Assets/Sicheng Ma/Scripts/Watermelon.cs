using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject p1 = GameObject.Find ("Boxforpitbull");
		BoxSnaps player = p1.GetComponent<BoxSnaps> ();

		if (player.isIn) {
			Destroy (gameObject);
		}
	}
}
