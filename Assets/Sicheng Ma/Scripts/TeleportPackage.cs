using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPackage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		GameObject p1 = GameObject.Find ("TeleportSpot");
		CJC_manageTeleport tele = p1.GetComponent<CJC_manageTeleport> ();
		if (other.tag == "Player") {
			CJC_manageTeleport.KnowsTeleport = true;
			Destroy (gameObject);
		}
	}
}
