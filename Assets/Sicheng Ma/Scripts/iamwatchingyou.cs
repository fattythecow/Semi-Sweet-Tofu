using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iamwatchingyou : MonoBehaviour {

	public GameObject monster;

	public GameObject Helpfultext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (monster == null) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			if (Helpfultext != null) 
			{
				Helpfultext.SetActive (true);
			}
		}
	}
}
