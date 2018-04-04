using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalyndece : MonoBehaviour {
	
	public GameObject exittext;

	public float timer = 0;
	// Use this for initialization
	void Start () {
		exittext.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (exittext.activeInHierarchy) {
			timer += Time.deltaTime;
			if (timer >= 2f) {
				exittext.SetActive (false);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Scroll") {
			exittext.SetActive (true);
		}

	}
}
