using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neverfalling : MonoBehaviour {

	public GameObject fruit;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		GameObject p2 = GameObject.FindWithTag ("Player");
		CJC_PlayerAndBools playeragain = p2.GetComponent<CJC_PlayerAndBools> ();

		if (fruit == null) {
			if (playeragain.IsGreen) {
				Destroy (gameObject);
			}
		}
	}
}
