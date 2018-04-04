using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrollPro : MonoBehaviour {

	public GameObject scroll1;

	public GameObject scrolllev2;

	public GameObject scroll3;

	public GameObject scroll4;

	// Use this for initialization
	void Start () {
		scroll1.SetActive (false);
		scrolllev2.SetActive (false);
		scroll3.SetActive (false);
		scroll4.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Scroll.scrollPickedup) {
			scroll1.SetActive (true);
		}
		else
			scroll1.SetActive (false);

		if (scroll2.scroll2Pickedup) {
			scrolllev2.SetActive (true);
		}
		else
			scrolllev2.SetActive (false);

		if (Scroll3.scroll3Pickedup) {
			scroll3.SetActive (true);
		} else {
			scroll3.SetActive (false);
		}
		if (scroll4ass.scroll4Pickedup) {
			scroll4.SetActive (true);
		} else {
			scroll4.SetActive (false);
		}

	}
}
