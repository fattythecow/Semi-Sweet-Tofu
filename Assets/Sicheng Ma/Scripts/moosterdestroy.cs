using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moosterdestroy : MonoBehaviour {

	public GameObject monster;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (monster == null) {
			Destroy (gameObject);
		}
	}
}
