using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class becomemaxhealth : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		GameObject p1 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools player = p1.GetComponent<CJC_PlayerAndBools> ();

		if (other.tag == "Player") {
			player.PlayerHealth = 100;
			Destroy (gameObject);
		}
	}
}
