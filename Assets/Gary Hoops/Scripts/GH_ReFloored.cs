using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GH_ReFloored : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
		void OnTriggerEnter (Collider other)
		{
			if (other.tag == "Player") {
				GameObject p1 = GameObject.FindWithTag ("Player");
				CJC_PlayerAndBools death = p1.GetComponent<CJC_PlayerAndBools> ();

				death.PlayerHealth = 0;
			}

			if (other.tag == "Monster") {
				Destroy (other.gameObject);
			}
		}
}
