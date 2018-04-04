using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleppickupTurto : MonoBehaviour {

	public GameObject TelepColl;

	public float timer = 0;

	public GameObject greenText;

	// Use this for initialization
	void Start () {
		greenText.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (TelepColl == null){
			greenText.SetActive (true);
			timer += Time.deltaTime;
		}

		if (greenText.activeInHierarchy) {
			if (timer >= 6) {
				greenText.SetActive (false);
			}
		}
	}


}
